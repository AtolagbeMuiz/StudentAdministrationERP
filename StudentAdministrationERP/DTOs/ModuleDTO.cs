using StudentAdministrationERP.Models;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.Serialization;
using System;
using System.ComponentModel.DataAnnotations;

namespace StudentAdministrationERP.DTOs
{
    public class ModuleDTO
    {
        public Guid Module_Id { get; set; }

        [Required]
        public int Module_Code { get; set; }

        [Required]
        public string Module_Title { get; set; }

        [ForeignKey("Degree")]
        public string Degree_Id { get; set; }
        public bool isCompulsory { get; set; }

       
    }
}
