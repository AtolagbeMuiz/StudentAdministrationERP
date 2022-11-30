using StudentAdministrationERP.Data;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace StudentAdministrationERP.Repository
{
    public class ModuleRepo : IModuleRepo
    {
        private StudentAdministrationERPDbContext _context;

        public ModuleRepo(StudentAdministrationERPDbContext context)
        {
            this._context = context;
        }

        public Module CreateModule(Module module)
        {
            if (module != null)
            {
                _context.Module.Add(module);
                _context.SaveChanges();

                return module;
            }
            return null;    
        }

        public bool EnrolStudentForModule(string[] arrayofModuleCodes, string studentId)
        {
            if(arrayofModuleCodes.Length > 0 && studentId != null)
            {
                foreach(var selectedModuleCode in arrayofModuleCodes)
                {
                    Enrolment enrolment = new Enrolment
                    {
                        Enrolment_Id = Guid.NewGuid(),
                        Module_Code = Convert.ToInt32(selectedModuleCode),
                        Student_Id = studentId
                    };
                    _context.Enrolment.Add(enrolment);
                    _context.SaveChanges();
                }

                return true;
            }
            return false;
        }


        public List<EnrolledCourseDetails> GetEnrolledModulesByStudentId(string studentId)
        {
            //_context.Enrolment.Where(x => x.)

            var enrolledModulesByStudent = (from enrolment in _context.Enrolment
                        join student in _context.Student on enrolment.Student_Id equals student.Student_Id
                        join module in _context.Module on enrolment.Module_Code equals module.Module_Code

                        where enrolment.Student_Id == studentId
                        select new EnrolledCourseDetails
                        {
                            Student_Id = enrolment.Student_Id,
                            Enrolment_Id = enrolment.Enrolment_Id,
                            Module_Code = enrolment.Module_Code,
                            Module_Title = module.Module_Title,
                            isEnrolled = student.isEnrolled
                        }).ToList();

            return enrolledModulesByStudent;
        }

       
    }
}
