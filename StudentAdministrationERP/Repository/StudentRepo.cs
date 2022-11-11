using StudentAdministrationERP.Data;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Models;
using StudentAdministrationERP.Interfaces;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;
using System.Collections.Generic;

namespace StudentAdministrationERP.Repository
{
    public class StudentRepo : IStudentRepo
    {
        private StudentAdministrationERPDbContext _context;
       
        //Constructor
        public StudentRepo(StudentAdministrationERPDbContext context)
        {
            this._context = context;  
        }

        public Student AddStudent(Student student)
        {
            if (student != null)
            {
               
                _context.Student.Add(student);
                _context.SaveChanges();

                return student;
            }
            return null;
        }

        public List<Student> GetStudents()
        {
            var students =  _context.Student.Select( x => new Student
            {
                Student_Id = x.Student_Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateOfBirth = x.DateOfBirth,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Degree = x.Degree,
                Degree_Id = x.Degree_Id,
                DateCreated = x.DateCreated,
                isEnrolled = x.isEnrolled
            }).ToList();

            return students;
        }

        public Student GetStudentDetailsById(string studentId)
        {
            var student = _context.Student.Select(x => new Student
            {
                Student_Id = x.Student_Id,
                FirstName = x.FirstName,
                LastName = x.LastName,
                DateOfBirth = x.DateOfBirth,
                Address = x.Address,
                Email = x.Email,
                PhoneNumber = x.PhoneNumber,
                Degree = x.Degree,
                Degree_Id = x.Degree_Id,
                DateCreated = x.DateCreated,
                isEnrolled = x.isEnrolled
            }).Where(x => x.Student_Id == studentId).FirstOrDefault();

            return student;
        }
    }
}
