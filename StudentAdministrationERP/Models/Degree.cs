using System;
using System.ComponentModel.DataAnnotations;

namespace StudentAdministrationERP.Models
{
    public class Degree
    {
        [Key]
        public string Degree_Id { get; set; }
        public string Degree_Title { get; set; }
        public int NoOfYears { get; set; }
        public DateTime DateCreated { get; set; }
    }
}
