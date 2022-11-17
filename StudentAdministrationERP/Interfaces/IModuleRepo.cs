using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Models;
using System.Collections.Generic;

namespace StudentAdministrationERP.Interfaces
{
    public interface IModuleRepo
    {
        Module CreateModule(Module module);
        bool EnrolStudentForModule(string[] arrayofModuleCodes, string studentId);
        List<EnrolledCourseDetails> GetEnrolledModulesByStudentId(string studentId);
    }
}
