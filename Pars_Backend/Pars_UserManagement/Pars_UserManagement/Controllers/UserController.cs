using Microsoft.AspNetCore.Mvc;

namespace Pars_UserManagement.Controllers
{
    [Route("user/")]
    [ApiController]
    public class UserController : Controller
    {
        // public IActionResult Index()
        // {
        //     return View();
        // }

        [HttpGet]
        [Route("{id:int}")]
        public ActionResult<string> Get(int id)
        {
            string number = (id * 5).ToString();
            return number;
        }

        [HttpGet]
        public ActionResult<string> Get()
        {
            string test = "hello world! :D";
            return test;
        }
    }
}
