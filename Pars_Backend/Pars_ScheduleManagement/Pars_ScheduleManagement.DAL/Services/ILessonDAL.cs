using Pars_ScheduleManagement.DAL.Models;

namespace Pars_ScheduleManagement.DAL.Services
{
    public interface ILessonDAL
    {
        Task<Lesson> AddLesson(Lesson Lesson);
        Task<ICollection<Lesson>> GetLessons();
        Task UpdateLesson(Lesson Lesson);
        Task<Lesson> GetLessonById(Guid id);
        Task DeleteLessonById(Guid id);
    }
}
