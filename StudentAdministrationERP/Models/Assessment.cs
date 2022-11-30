using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace StudentAdministrationERP.Models
{
    public class Assessment
    {
        [Key]
        public Guid Assessment_Id { get; set; }
        public string Assessment_Title { get; set; }

        public double Assessment_Mark { get; set; }

        [ForeignKey("Degree")]
        public string Degree_Id { get; set; }

        [IgnoreDataMember]
        public virtual Degree Degree { get; set; }



        [ForeignKey("Module")]
        public Guid Module_Id { get; set; }

        [IgnoreDataMember]
        public virtual Module Module { get; set; }
    }
}
