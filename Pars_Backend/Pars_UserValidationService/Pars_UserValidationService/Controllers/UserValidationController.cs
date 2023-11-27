using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pars_UserValidation.Core.API.Services;
using Pars_UserValidation.DAL.Models;
using Pars_UserValidation.DAL.Services;

namespace Pars_UserValidation.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class UserValidationController : Controller
    {
        private readonly IUserValidationService _userValidationService;

        public UserValidationController(IUserValidationService userValidationService)
        {
            _userValidationService = userValidationService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _userValidationService.GetUserValidations());
        }

        [HttpGet("{Id:guid}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(Guid Id)
        {
            return Ok(await _userValidationService.GetValidationById(Id));
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddUser(UserValidationModel userValidation)
        {
            return Ok(_userValidationService.AddUserValidation(userValidation));
        }

        [HttpPut]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateUser(UserValidationModel userValidation)
        {
            return Ok(_userValidationService.AddUserValidation(userValidation));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteUserById(Guid Id)
        {
            _userValidationService.DeleteUserValidationById(Id);
            return Ok();
        }
    }
}
