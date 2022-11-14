using StudentAdministrationERP.Data;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;
using System;

namespace StudentAdministrationERP.Repository
{
    public class ModuleRepo : IModuleRepo
    {
        private StudentAdministrationERPDbContext _context;

        public ModuleRepo(StudentAdministrationERPDbContext context)
        {
            this._context = context;
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
    }
}
