using CarsShowroom.Core.Contracts;
using CarsShowroom.Core.Models.Customer;
using Microsoft.AspNetCore.Mvc;
using System.Security.Claims;

namespace CarsShowroom.Controllers
{
    public class CustomerController : BaseController
    {
        private readonly ICustomerService customerService;
        public CustomerController(ICustomerService _customerService)
        {
            customerService = _customerService;
        }

        [HttpGet]
        public async Task<IActionResult> Add()
        {
            var model = new CustomerFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> Add(CustomerFormModel model)
        {
            if (ModelState.IsValid == false)
            {
                return BadRequest();
            }

            string userId = GetUserId();
            await customerService.CreateAsync(userId, model.Name, model.PhoneNumber, model.Address);

            return RedirectToAction(nameof(VehicleController.Add), "Vehicle");
        }

        private string GetUserId()
        {
            return User.FindFirstValue(ClaimTypes.NameIdentifier);
        }
    }
}
