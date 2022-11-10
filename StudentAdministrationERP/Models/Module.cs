using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;

namespace StudentAdministrationERP.Models
{
    public class Module
    {
        [Key]
        public Guid Module_Id { get; set; }
        public int Module_Code { get; set; }
        public string Module_Title { get; set; }

        [ForeignKey("Degree")]
        public string Degree_Id { get; set; }

        [IgnoreDataMember]
        public virtual Degree Degree { get; set; }
    }
}
