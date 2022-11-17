using StudentAdministrationERP.Data;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;

namespace StudentAdministrationERP.Repository
{
    public class AssessmentRepo : IAssessmentRepo
    {
        private StudentAdministrationERPDbContext _context;

        public AssessmentRepo(StudentAdministrationERPDbContext context)
        {
            this._context = context;
        }

        public Assessment CreateAssessment(Assessment assessment)
        {
            if (assessment != null)
            {

                _context.Assessment.Add(assessment);
                _context.SaveChanges();

                return assessment;
            }
            return null;
        }
    }
}
