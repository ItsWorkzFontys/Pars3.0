using Microsoft.AspNetCore.Mvc;

namespace Pars_UserManagement.Controllers
{
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
