using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StudentAdministrationERP.Interfaces
{
    public interface IStudentRepo
    {
        Student AddStudent(Student student);
        List<Student> GetStudents();
        Student GetStudentDetailsById(string studentId);
    }
}
