using CarsShowroom.Core.Contracts;
using CarsShowroom.Core.Models.Vehicle;
using CarsShowroom.Extensions;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarsShowroom.Controllers
{
    public class VehicleController : BaseController
    {
        private readonly IVehicleService vehicleService;
        private readonly ICustomerService customerService;
        public VehicleController(IVehicleService _vehicleService, ICustomerService _customerService)
        {
            vehicleService = _vehicleService;
            customerService = _customerService;
        }

        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> All()
        {
            var model = await vehicleService.AllVehiclesAsync();

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
            string userId = GetUserId();
            bool customerExists = await customerService.ExistByIdAsync(userId);
            if (!customerExists)
            {
                return RedirectToAction(nameof(Add), "Customer");
            }

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

            string userId = GetUserId();
            bool userExists = await customerService.ExistByIdAsync(userId);
            if (!userExists)
            {
                return RedirectToAction("Add", "Customer");
            }

            int customerId = await customerService.GetCustomerIdAsync(User.Id());
            int newVehicleId = await vehicleService.CreateAsync(vehicle, customerId);

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

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
