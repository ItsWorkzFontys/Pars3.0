using Microsoft.AspNetCore.Mvc;
using Pars_ConfigurationServices.Models;
using Pars_ConfigurationServices.Services;

namespace Pars_ConfigurationServices.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ConfigurationController : ControllerBase
    {
        private readonly ConfigurationService _configurationService;

        public ConfigurationController(ConfigurationService configurationService)
        {
            _configurationService = configurationService;
        }

        [HttpGet("{schoolId}")]
        public IActionResult GetSchoolConfiguration(int schoolId)
        {
            var configuration = _configurationService.GetSchoolConfiguration(schoolId);

            if (configuration == null)
            {
                return BadRequest();
            }

            return Ok(configuration);
        }

        [HttpPost]
        public IActionResult CreateSchoolConfiguration([FromBody] SchoolConfiguration schoolConfiguration, int userId)
        {
            try
            {
                _configurationService.CreateSchoolConfiguration(schoolConfiguration, userId);
                return Ok("Creation successful");
            }
            catch (Exception ex)
            {
                return BadRequest($"Creation failed: {ex.Message}");
            }
        }

        [HttpDelete]
        public IActionResult DeleteSchoolConfiguration(int userId, int schoolId)
        {
            try
            {
                _configurationService.DeleteSchoolConfiguration(userId, schoolId);
                return Ok("Deletion successful");
            }
            catch (Exception ex)
            {
                return BadRequest($"Deletion failed: {ex.Message}");
            }
        }

        [HttpPut("number-of-students")]
        public IActionResult UpdateNumberOfStudents(int schoolId, int userId, int newNumOfStudents)
        {
            var success = _configurationService.UpdateNumberOfStudents(schoolId, userId, newNumOfStudents);

            if (!success)
            {
                return Forbid();
            }

            return Ok();
        }

        [HttpPut("absence-color")]
        public IActionResult UpdateAbsenceColor(int schoolId, int userId, string newAbsenceColor)
        {
            var success = _configurationService.UpdateAbsenceColor(schoolId, userId, newAbsenceColor);

            if (!success)
            {
                return Forbid();
            }

            return Ok();
        }

        [HttpPut("presence-color")]
        public IActionResult UpdatePresenceColor(int schoolId, int userId, string newPresenceColor)
        {
            var success = _configurationService.UpdatePresenceColor(schoolId, userId, newPresenceColor);

            if (!success)
            {
                return Forbid();
            }

            return Ok();
        }

        [HttpPut("late-color")]
        public IActionResult UpdateLateColor(int schoolId, int userId, string newLateColor)
        {
            var success = _configurationService.UpdateLateColor(schoolId, userId, newLateColor);

            if (!success)
            {
                return Forbid();
            }

            return Ok();
        }


        [HttpPut("{schoolId}/{userId}")]
        public ActionResult UpdateSchoolConfiguration(int schoolId, int userId, [FromBody] SchoolConfiguration newConfiguration)
        {
            var success = _configurationService.UpdateSchoolConfiguration(schoolId, newConfiguration, userId);

            if (!success)
            {
                return Forbid(); // or BadRequest(), depending on your error handling strategy
            }

            return Ok();
        }
    }
}

