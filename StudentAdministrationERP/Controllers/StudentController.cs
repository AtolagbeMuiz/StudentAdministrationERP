using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;
using StudentAdministrationERP.Repository;
using System.Net;

namespace StudentAdministrationERP.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private IStudentService _studentService;
        private IDegreeService _degreeService;
        private IModuleService _moduleService;

        public StudentController(ILogger<StudentController> logger, IStudentService studentService, IDegreeService degreeService, IModuleService moduleService)
        {
            this._studentService = studentService;
            _logger = logger;
            this._degreeService = degreeService;
            _moduleService = moduleService;
        }
        public IActionResult Index()
        {
            try
            {
                //Fetch the List of Available Degrees from the DB
                //Assign this list in a viewbag 
                //then populate this list in a drop down on the view
                 var degrees = _degreeService.GetDegrees();

                if(degrees != null)
                {
                    ViewBag.Degrees = new SelectList(degrees, "Degree_Id", "Degree_Title");
                    return View();
                }
                return View();
            }
            catch (System.Exception ex)
            {
                _logger.LogInformation("------Error thrown while trying to displaying form to register student");
                _logger.LogError("The Error is " + ex.Message);
                throw;
            }
           
        }

        [HttpPost]
        public IActionResult Index(StudentDTO studentDTO)
        {
            try
            {
                if (ModelState.IsValid)
                {
              
                    //save Student details
                    var response = this._studentService.SaveStudentDetails(studentDTO);
                    if (response == HttpStatusCode.OK)
                    {
                        return View();
                    }
                }
                return View();
            }
            catch (System.Exception ex)
            {
                _logger.LogInformation("------Error thrown while trying to save Stdent details");
                _logger.LogError("The Error is " + ex.Message);
                throw;
            }
           
        }

        public IActionResult GetStudents()
        {
            var studentList = _studentService.GetStudents();
            if (studentList.Count > 0)
            {
                return View(studentList);
            }

            return View();
        }

        public IActionResult StudentDetails(string studentId)
        {
            var student = _studentService.GetStudentDetailsById(studentId);
            if(student != null)
            {
                if(student.isEnrolled == false) 
                {
                    //Go to fetch the modules associated to the student's degree
                    var listOfModulesAttachedToADegree = _degreeService.GetDegreeModules(student.Degree_Id);
                    ViewBag.listOfModulesAttachedToADegree  = listOfModulesAttachedToADegree;

                    return View(student);
                }
                else
                {
                    var modulesEnrolledbyStudent = _moduleService.GetEnrolledModulesByStudentId(student.Student_Id);
                    ViewBag.listOfModulesEnrolledByStudent = modulesEnrolledbyStudent;
                    return View(student);

                }

            }
            return RedirectToAction("GetStudents");
        }

        [HttpPost]
        public IActionResult EnrolStudent([FromBody] SelectedModule selectedModule)//string[] ModuleCode, string Student_Id)
        {
            var studentId = selectedModule.Student_Id.ToString();
            string[] arrayofModuleCodes = selectedModule.ModuleCode;

            var isEnrolled = _moduleService.EnrolStudentForModule(arrayofModuleCodes, studentId);
            if(isEnrolled == true)
            {
               var enrolmentStatusUpdated = _studentService.UpdateStudentEnrolmentStatus(studentId);
               
                if(enrolmentStatusUpdated == true)
                {
                    return RedirectToAction("GetStudents");
                }
            }
            return null;
        }
    }
}
