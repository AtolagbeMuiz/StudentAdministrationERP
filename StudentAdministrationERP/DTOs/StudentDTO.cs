using System;
using System.ComponentModel.DataAnnotations;

namespace StudentAdministrationERP.DTOs
{
    public class StudentDTO
    {
        public string Student_Id { get; set; }

        [Required]
        public string FirstName { get; set; }

        [Required]
        public string LastName { get; set; }

        [Required]
        public DateTime DateOfBirth { get; set; }

        [Required]
        public string Email { get; set; }

        [Required]
        public string PhoneNumber { get; set; }

        [Required]
        public string Address { get; set; }

        public string Degree_Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool isEnrolled { get; set; }
    }
}
