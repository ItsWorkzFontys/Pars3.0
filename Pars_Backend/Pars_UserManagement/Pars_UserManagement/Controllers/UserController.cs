using Microsoft.AspNetCore.Mvc;

namespace Pars_UserManagement.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet("{id}")]
        public IActionResult Get(long id)
        {
            string number = id * 5;
            return Ok(number);
        }

        [HttpGet]
        public IActionResult Get()
        {
            string test = "hello world! :D";
            return Ok(test);
        }
    }
}
