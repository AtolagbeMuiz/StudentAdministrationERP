using System.ComponentModel.DataAnnotations;
using System;

namespace StudentAdministrationERP.DTOs
{
    public class DegreeDTO
    {
        public string Degree_Id { get; set; }
        public string Degree_Title { get; set; }
        public int NoOfYears { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
