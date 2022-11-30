using System.ComponentModel.DataAnnotations.Schema;
using System;
using System.ComponentModel.DataAnnotations;

namespace StudentAdministrationERP.DTOs
{
    public class AssessmentDTO
    {
        public Guid Assessment_Id { get; set; }

        [Required]
        public string Assessment_Title { get; set; }

        public double Assessment_Mark { get; set; }
        public Guid Module_Id { get; set; }
        public string Degree_Id { get; set; }
    }
}
