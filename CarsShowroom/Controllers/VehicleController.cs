using CarsShowroom.Core.Contracts;
using CarsShowroom.Core.Models.Vehicle;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarsShowroom.Controllers
{
    public class VehicleController : BaseController
    {
        private readonly IVehicleService vehicleService;
        public VehicleController(IVehicleService _vehicleService)
        {
            vehicleService = _vehicleService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = new AllVehiclesQueryModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Details(int id)
        {
            var model = new VehicleDetailsViewModel();

            return View(model);
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new VehicleFormModel()
            {
                Manufacturers = await vehicleService.AllManufacturersAsync()
            };

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(VehicleFormModel vehicle)
        {
            if (await vehicleService.ManufacturerExistsAsync(vehicle.ManufacturerId) == false)
            {
                ModelState.AddModelError(nameof(vehicle.ManufacturerId), "");
            }

            if (ModelState.IsValid == false)
            {
                vehicle.Manufacturers = await vehicleService.AllManufacturersAsync();

                return View(vehicle);
            }

            int newVehicleId = await vehicleService.CreateAsync(vehicle);

            return RedirectToAction(nameof(Details), new { id = newVehicleId });
        }

        [HttpGet]
        public async Task<IActionResult> Edit(int id)
        {
            return View(new VehicleFormModel());
        }

        [HttpGet]
        public async Task<IActionResult> Delete(int id)
        {
            return View(new VehicleDetailsViewModel());
        }

        [HttpPost]
        public async Task<IActionResult> Delete(VehicleDetailsViewModel model)
        {
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Inspect(int id)
        {
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Test(int id)
        {
            return RedirectToAction(nameof(All));
        }

        [HttpPost]
        public async Task<IActionResult> Sale(int id)
        {
            return RedirectToAction(nameof(All));
        }
    }
}
