using Microsoft.AspNetCore.Mvc;

namespace Pars_UserValidationService.Controllers
{
    public class UserValidationController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
