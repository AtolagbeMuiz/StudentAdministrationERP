using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace StudentAdministrationERP.Models
{
    public class Student
    {
        [Key]
        public string Student_Id { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Address { get; set; }

        [ForeignKey("Degree")]
        public string Degree_Id { get; set; }
        public DateTime DateCreated { get; set; }
        public bool isEnrolled { get; set; }


        [IgnoreDataMember]
        public virtual Degree Degree { get; set; }


    }
}
