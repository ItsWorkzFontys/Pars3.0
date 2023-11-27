using Microsoft.AspNetCore.Mvc;

namespace Pars_UserManagement.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class UserController : ControllerBase
    {
        // public IActionResult Index()
        // {
        //     return View();
        // }

        // private readonly IUserValidationService _userValidationService;

        // public UserValidationController(IUserValidationService userValidationService)
        // {
        //     _userValidationService = userValidationService;
        // }

        // GET api/user/idparam/{id}
        [HttpGet]
        [Route("idparam/{id}")]
        public ActionResult<string> GetGet(int id)
        {
            string number = (id * 5).ToString();
            return Ok(number);
        }

        // GET api/user/test?id={int}
        [HttpGet]
        [Route("test")]
        public ActionResult<string> Get([FromQuery]int id)
        {
            string number = (id * 5).ToString();
            return Ok(number);
        }

        // GET api/user
        [HttpGet]
        public ActionResult<string> Get()
        {
            string test = "hello world! :D";
            return Ok(test);
        }

        // [HttpGet]
        // [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        // public async Task<IActionResult> GetAll()
        // {
        //     return Ok(await _userValidationService.GetUserValidations());
        // }

        // [HttpGet("{Id:guid}")]
        // [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        // public async Task<IActionResult> GetById(Guid Id)
        // {
        //     return Ok(await _userValidationService.GetValidationById(Id));
        // }

        // [HttpPost]
        // [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        // public async Task<IActionResult> AddUser(UserValidationModel userValidation)
        // {
        //     return Ok(_userValidationService.AddUserValidation(userValidation));
        // }

        // [HttpPut]
        // [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        // public async Task<IActionResult> UpdateUser(UserValidationModel userValidation)
        // {
        //     return Ok(_userValidationService.AddUserValidation(userValidation));
        // }

        // [HttpDelete]
        // [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        // public async Task<IActionResult> DeleteUserById(Guid Id)
        // {
        //     _userValidationService.DeleteUserValidationById(Id);
        //     return Ok();
        // }
    }
}
