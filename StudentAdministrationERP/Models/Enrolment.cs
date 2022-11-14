using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace StudentAdministrationERP.Models
{
    public class Enrolment
    {
        [Key]
        public Guid Enrolment_Id { get; set; }

        [ForeignKey("Student")]
        public string Student_Id { get; set; }

        public int Module_Code { get; set; }




        [IgnoreDataMember]
        public virtual Student Student { get; set; }
    }
}
