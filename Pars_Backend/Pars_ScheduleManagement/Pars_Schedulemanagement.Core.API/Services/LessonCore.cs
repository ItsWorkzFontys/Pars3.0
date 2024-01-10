using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pars_ScheduleManagement.DAL.Models;
using Pars_ScheduleManagement.DAL.Services;

namespace Pars_ScheduleManagement.Core.API.Services
{
    public class LessonCore : ILessonService
    {
        private readonly ILessonDAL _LessonDAL;
        public LessonCore(ILessonDAL LessonDAL)
        {
            _LessonDAL = LessonDAL;
        }

        public async Task<Lesson> AddLesson(Lesson Lesson)
        {
            return await _LessonDAL.AddLesson(Lesson);      
        }

        public Task DeleteLessonById(Guid id)
        {
            return _LessonDAL.DeleteLessonById(id);
        }

        public async Task<ICollection<Lesson>> GetLessons()
        {
            return await _LessonDAL.GetLessons();
        }

        public async Task<Lesson> GetLessonById(Guid id)
        {
            return await _LessonDAL.GetLessonById(id);
        }

        public async Task UpdateLesson(Lesson Lesson)
        {
            await _LessonDAL.UpdateLesson(Lesson);
        }
    }
}
