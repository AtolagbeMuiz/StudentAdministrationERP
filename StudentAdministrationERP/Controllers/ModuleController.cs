using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using StudentAdministrationERP.DTOs;
using StudentAdministrationERP.Interfaces;

namespace StudentAdministrationERP.Controllers
{
    public class ModuleController : Controller
    {
        private readonly IModuleService _moduleService;
        private readonly IDegreeService _degreeService;
        public ModuleController(IModuleService moduleService, IDegreeService degreeService)
        {
            _moduleService = moduleService;
            _degreeService = degreeService;
        }

        [HttpGet]
        public IActionResult Index()
        {
            var degrees = _degreeService.GetDegrees();

            if (degrees != null)
            {
                ViewBag.Degrees = new SelectList(degrees, "Degree_Id", "Degree_Title");
                return View();
            }
            return View();
        }

        [HttpPost]
        public IActionResult Index(ModuleDTO module)
        {
            if (ModelState.IsValid)
            {
                var moduleCreated = _moduleService.CreateModule(module);
                if(moduleCreated == true)
                {
                    return RedirectToAction("Index");
                }
            }
            return View();

        }
    }
}
