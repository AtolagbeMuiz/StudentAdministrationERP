using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Models;
using System.Collections.Generic;

namespace StudentAdministrationERP.Interfaces
{
    public interface IDegreeService
    {
        void CreateDegree(Degree degree);

        List<DegreeDTO> GetDegrees();

        List<Module> GetDegreeModules(string degreeId);
    }
}
