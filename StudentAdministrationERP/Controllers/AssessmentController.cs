using Microsoft.AspNetCore.Mvc;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;

namespace StudentAdministrationERP.Controllers
{
    public class AssessmentController : Controller
    {
        private readonly IAssessmentService _assessmentService;
        private readonly IDegreeService _degreeService;

        public AssessmentController(IAssessmentService assessmentService, IDegreeService degreeService)
        {
            this._assessmentService = assessmentService;
            _degreeService = degreeService;
        }
        public IActionResult Index()
        {
            var degrees = _degreeService.GetDegrees();
            if(degrees != null)
            {
                ViewBag.Degrees = degrees;
                return View();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(AssessmentDTO assessmentDTO)
        {
            return View();
        }
    }
}
