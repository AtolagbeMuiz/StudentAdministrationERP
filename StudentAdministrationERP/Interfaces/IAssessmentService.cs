using StudentAdministrationERP.DTOs;
using System.Net;

namespace StudentAdministrationERP.Interfaces
{
    public interface IAssessmentService
    {
        HttpStatusCode CreateAssessment(AssessmentDTO assessmentDTO);
    }
}
