using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace CarsShowroom.Controllers
{
    [Authorize]
    public class BaseController : Controller
    {
    }
}
