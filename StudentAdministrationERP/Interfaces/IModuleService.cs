using StudentAdministrationERP.DTOs;
using System.Collections.Generic;

namespace StudentAdministrationERP.Interfaces
{
    public interface IModuleService
    {
        bool CreateModule(ModuleDTO moduleDTO);
        bool EnrolStudentForModule(string[] arrayofModuleCodes, string studentId);
        List<EnrolledCourseDetails> GetEnrolledModulesByStudentId(string studentId);
    }
}
