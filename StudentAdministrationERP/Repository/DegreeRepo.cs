using StudentAdministrationERP.Data;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;
using System.Collections.Generic;
using System.Linq;

namespace StudentAdministrationERP.Repository
{
    public class DegreeRepo : IDegreeRepo
    {
        private StudentAdministrationERPDbContext _context;

        public DegreeRepo(StudentAdministrationERPDbContext context)
        {
            this._context = context;
        }

        public void CreateDegree(Degree degree)
        {
            if (degree != null)
            {
                _context.Degree.Add(degree);
                _context.SaveChanges();

            }
        }

        public List<DegreeDTO> GetDegrees()
        {
            var degrees = _context.Degree.Select(x => new DegreeDTO
            {
                Degree_Id = x.Degree_Id,
                Degree_Title = x.Degree_Title,
                NoOfYears = x.NoOfYears
            }).ToList();

            return degrees;
        }

    }
    
}
