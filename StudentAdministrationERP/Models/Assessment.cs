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
        public string Asessment_Title { get; set; }

        [ForeignKey("Module")]
        public Guid Module_Id { get; set; }

        [IgnoreDataMember]
        public virtual Module Module { get; set; }
    }
}
