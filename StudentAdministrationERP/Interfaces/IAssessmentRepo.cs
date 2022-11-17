using Microsoft.EntityFrameworkCore;
using StudentAdministrationERP.Models;

namespace StudentAdministrationERP.Interfaces
{
    public interface IAssessmentRepo
    {
        Assessment CreateAssessment(Assessment assessment);
        
    }
}
