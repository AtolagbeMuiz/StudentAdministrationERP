using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Models;
using System.Collections.Generic;
using System.Net;
using System.Threading.Tasks;

namespace StudentAdministrationERP.Interfaces
{
    public interface IStudentService
    {
        HttpStatusCode SaveStudentDetails(StudentDTO student);

        List<Student> GetStudents();

        Student GetStudentDetailsById(string studentId);
    }
}
