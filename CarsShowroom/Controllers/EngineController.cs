using CarsShowroom.Core.Contracts;
using CarsShowroom.Core.Models.Engine;
using CarsShowroom.Core.Models.Vehicle;
using Microsoft.AspNetCore.Mvc;

namespace CarsShowroom.Controllers
{

    public class EngineController : Controller
    {
        private readonly IEngineService engineService;
        public EngineController(IEngineService _engineService)
        {
            engineService = _engineService;
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = new EngineFormModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> AddEngine()
        {
            var model = new EngineFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddEngine(EngineFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                return View(model);
            }

            await engineService.CreateAsync(model);
            
            return RedirectToAction(nameof(Details),new {id=1});
        }
    }
}
