using AutoMapper;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;
using System;
using System.Collections.Generic;

namespace StudentAdministrationERP.Services
{
    public class ModuleService : IModuleService
    {
        private IModuleRepo _moduleRepo;
        private IMapper _mapper;

        public ModuleService(IModuleRepo moduleRepo, IMapper mapper)
        {
            _moduleRepo = moduleRepo;
            _mapper = mapper;
        }

        //Creates a Module
        public bool CreateModule(ModuleDTO moduleDTO)
        {
            if(moduleDTO != null)
            {
                moduleDTO.Module_Id = Guid.NewGuid();
                //Automapping the ModuleDTO to the Module Entity
                var module = _mapper.Map<Module>(moduleDTO);

                var moduleCreated = _moduleRepo.CreateModule(module);
                if(moduleCreated != null)
                {
                    return true;
                }
                
            }
            return false;
        }

        public bool EnrolStudentForModule(string[] arrayofModuleCodes, string studentId)
        {
            var isEnrolled = _moduleRepo.EnrolStudentForModule(arrayofModuleCodes, studentId);

            if (isEnrolled)
            {
                return true;
            }
            return false;

        }

        public List<EnrolledCourseDetails> GetEnrolledModulesByStudentId(string studentId)
        {
            var enrolledModulesByStudent = _moduleRepo.GetEnrolledModulesByStudentId(studentId);
            if(enrolledModulesByStudent != null)
            {
                return enrolledModulesByStudent;
            }
            return null;
        }
    }
}
