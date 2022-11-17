using AutoMapper;
using Microsoft.Extensions.Logging;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Models;

namespace StudentAdministrationERP.Helpers
{
    public class AutoMapping : Profile
    {
        public AutoMapping()
        {
            CreateMap<StudentDTO, Student>().ReverseMap();
            CreateMap<ModuleDTO, Module>().ReverseMap();
        }
    }
}
