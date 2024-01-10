using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Pars_ScheduleManagement.Core.API.Services;
using Pars_ScheduleManagement.DAL.Models;
using Pars_ScheduleManagement.DAL.Services;

namespace Pars_Lesson.Controllers
{
    [Route("[controller]s")]
    [ApiController]
    public class LessonController : Controller
    {
        private readonly ILessonService _LessonService;

        public LessonController(ILessonService LessonService)
        {
            _LessonService = LessonService;
        }
        [HttpGet]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetAll()
        {
            return Ok(await _LessonService.GetLessons());
        }

        [HttpGet("{Id:guid}")]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> GetById(Guid Id)
        {
            return Ok(await _LessonService.GetLessonById(Id));
        }

        [HttpPost]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> AddUser(Lesson Lesson)
        {
            return Ok(await _LessonService.AddLesson(Lesson));
        }

        [HttpPut]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> UpdateUser(Lesson Lesson)
        {
            return Ok(_LessonService.AddLesson(Lesson));
        }

        [HttpDelete]
        [ProducesResponseType(typeof(string), StatusCodes.Status200OK)]
        public async Task<IActionResult> DeleteUserById(Guid Id)
        {
            _LessonService.DeleteLessonById(Id);
            return Ok();
        }
    }
}
