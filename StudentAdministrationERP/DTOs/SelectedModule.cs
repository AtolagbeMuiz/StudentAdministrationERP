using System;
using System.Collections;

namespace StudentAdministrationERP.DTOs
{
    public class SelectedModule
    {

        //Student Info
        //public string Student_Id { get; set; }
        //public string FirstName { get; set; }
        //public string LastName { get; set; }
        //public DateTime DateOfBirth { get; set; }
        //public string Email { get; set; }
        //public string PhoneNumber { get; set; }
        //public string Address { get; set; }
        //public string Degree_Id { get; set; }
        //public bool isEnrolled { get; set; }

        ////Module Info
        //public Guid Module_Id { get; set; }
        //public int Module_Code { get; set; }
        //public string Module_Title { get; set; }


        public string[] ModuleCode { get; set; }
        public int Student_Id { get; set; }
    }
}
