using CarsShowroom.Core.Models.Appointment;
using Microsoft.AspNetCore.Mvc;

namespace CarsShowroom.Controllers
{
    public class CustomerController : BaseController
    {
        [HttpGet]
        public async Task<IActionResult> AddCustomer()
        {
            var model = new AppointmentFormModel();

            return View(model);
        }

        [HttpPost]
        public async Task<IActionResult> AddCustomer(AppointmentFormModel model)
        {
            return RedirectToAction(nameof(Index));
        }
    }
}
