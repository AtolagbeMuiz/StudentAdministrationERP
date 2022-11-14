using AutoMapper;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;
using System.Collections.Generic;

namespace StudentAdministrationERP.Services
{
    public class DegreeService : IDegreeService
    {
        private IDegreeRepo _degreeRepo;
        public DegreeService(IDegreeRepo degreeRepo)
        {
            _degreeRepo = degreeRepo;
        }

        public void CreateDegree(Degree degree)
        {
            this._degreeRepo.CreateDegree(degree);
        }

        public List<DegreeDTO> GetDegrees()
        {
            var degrees = this._degreeRepo.GetDegrees();
            if(degrees.Count > 0)
            {
                return degrees;
            }
            return null;
        }
        
        public List<Module> GetDegreeModules(string degreeId)
        {
            var degreeModules = _degreeRepo.GetDegreeModules(degreeId);

            if(degreeModules.Count > 0)
            {
                return degreeModules;
            }
            return null ;
        }
    }
}
