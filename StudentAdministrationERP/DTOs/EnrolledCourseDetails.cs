using System.ComponentModel.DataAnnotations.Schema;
using System;

namespace StudentAdministrationERP.DTOs
{
    public class EnrolledCourseDetails
    {
        public int Module_Code { get; set; }
        public string Module_Title { get; set; }

        public Guid Enrolment_Id { get; set; }

        public bool isEnrolled { get; set; }
        public string Student_Id { get; set; }

    }
}
