using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;
using System;
using System.Collections.Generic;
using System.Net;

namespace StudentAdministrationERP.Services
{
    public class StudentService : IStudentService
    {
        private IStudentRepo _studentRepo;
        private IMapper _mapper;

        public StudentService(IStudentRepo studentRepo, IMapper mapper)
        {
            _studentRepo = studentRepo;
            this._mapper = mapper;
        }
        public HttpStatusCode SaveStudentDetails(StudentDTO studentDTO)
        {
            //Generate 6 digits random number
            Random rnd = new Random();
            int uniqueNumber = rnd.Next(100000, 999999);

            //concatenate this 6 digits random number to the currrent year to form a Unique StudentId
            string studendId = Convert.ToString(DateTime.Today.Year) + uniqueNumber.ToString();

            //Assign this unique student ID to StudentDTO object
            studentDTO.Student_Id = studendId;
            studentDTO.DateCreated = DateTime.Today;

            //Automapping the StudentDTO to the Student Entity
            var student = _mapper.Map<Student>(studentDTO);

            var response = _studentRepo.AddStudent(student);
            
            if(response != null)
            {
                return HttpStatusCode.OK;
            }
            else
            {
                return HttpStatusCode.BadRequest;
            }
        }

        public List<Student> GetStudents()
        { 
            var students = _studentRepo.GetStudents();

            if (students != null)
            {
                return students;
            }
            return null;
        }

        public Student GetStudentDetailsById(string studentId)
        {
            var student = _studentRepo.GetStudentDetailsById(studentId);
            if (student != null)
            {
                return student;
            }
            return null;
        }
    }
}
