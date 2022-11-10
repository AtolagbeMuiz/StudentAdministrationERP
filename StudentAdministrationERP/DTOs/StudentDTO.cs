using System;

namespace StudentAdministrationERP.DTOs
{
    public class StudentDTO
    {
        public string Student_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }
        public string Degree_Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool isEnrolled { get; set; }
    }
}
