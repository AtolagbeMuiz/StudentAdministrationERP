using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace StudentAdministrationERP.DTOs
{
    public class AssessmentDTO
    {
        public Guid Assessment_Id { get; set; }
        public string Asessment_Title { get; set; }
        public Guid Module_Id { get; set; }
    }
}
