using AutoMapper;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;
using System;
using System.Net;

namespace StudentAdministrationERP.Services
{
    public class AssessmentService : IAssessmentService
    {
        private readonly IAssessmentRepo _assessmentRepo;
        private readonly IMapper _mapper;
        public AssessmentService(IAssessmentRepo assessmentRepo, IMapper mapper)
        {
            _assessmentRepo = assessmentRepo;
            _mapper = mapper;
        }

        public HttpStatusCode CreateAssessment(AssessmentDTO assessmentDTO)
        {
            if(assessmentDTO != null)
            {
                assessmentDTO.Assessment_Id = Guid.NewGuid();

                var assessment = _mapper.Map<Assessment>(assessmentDTO);

                var assesmentCreated = _assessmentRepo.CreateAssessment(assessment);

                if(assesmentCreated != null)
                {
                    return HttpStatusCode.OK;
                }
              
            }
            return HttpStatusCode.BadRequest;
        }
    }
}
