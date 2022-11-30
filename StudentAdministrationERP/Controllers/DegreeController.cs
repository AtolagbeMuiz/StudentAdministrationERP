using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using StudentAdministrationERP.Interfaces;
using StudentAdministrationERP.Models;

namespace StudentAdministrationERP.Controllers
{
    public class DegreeController : Controller
    {
        private readonly ILogger<DegreeController> _logger;
        private IDegreeService _degreeService;
        private IMapper _mapper;

        public DegreeController(ILogger<DegreeController> logger, IDegreeService degreeService, IMapper mapper)
        {
            this._mapper = mapper;
            this._degreeService = degreeService;
            _logger = logger;
        }
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult CreateDegree(Degree degree)
        {
            try
            {
                this._degreeService.CreateDegree(degree);
                return View();

            }
            catch (System.Exception ex)
            {
                _logger.LogInformation("------Error thrown while trying to save Degree details");
                _logger.LogError("The Error is " + ex.Message);
                throw;
            }
        }

        public IActionResult GetDegreeModules(string selectedDegree)
        {
           var modulesAssignedToDegree = _degreeService.GetDegreeModules(selectedDegree);
            if(modulesAssignedToDegree != null)
            {
                ViewBag.DegreeModules = modulesAssignedToDegree;
            
            }
            return null;
        }
    }
}
