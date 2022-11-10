using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Models;
using System.Collections.Generic;

namespace StudentAdministrationERP.Interfaces
{
    public interface IDegreeRepo
    {
        void CreateDegree(Degree degree);
        List<DegreeDTO> GetDegrees();
    }
}
