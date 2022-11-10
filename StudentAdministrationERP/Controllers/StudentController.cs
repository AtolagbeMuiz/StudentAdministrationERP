using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.Extensions.Logging;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;
using System.Net;

namespace StudentAdministrationERP.Controllers
{
    public class StudentController : Controller
    {
        private readonly ILogger<StudentController> _logger;
        private IStudentService _studentService;
        private IDegreeService _degreeService;

        public StudentController(ILogger<StudentController> logger, IStudentService studentService, IDegreeService degreeService)
        {
            this._studentService = studentService;
            _logger = logger;
            this._degreeService = degreeService;
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
            var response = _studentService.GetStudents();
            if (response != null)
            {
                return View();
            }

            return View();
        }
    }
}
