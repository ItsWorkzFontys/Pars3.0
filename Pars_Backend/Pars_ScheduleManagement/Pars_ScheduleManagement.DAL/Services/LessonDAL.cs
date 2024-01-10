using Pars_ScheduleManagement.DAL.Context;
using Pars_ScheduleManagement.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace Pars_ScheduleManagement.DAL.Services
{
    public class LessonDAL : ILessonDAL
    {
        private readonly ScheduleManagementDbContext db;

        public LessonDAL(ScheduleManagementDbContext db)
        {
            this.db = db;
        }

        public async Task<Lesson> AddLesson(Lesson lesson)
        {
            db.Lesson.Add(lesson);
            await db.SaveChangesAsync();
            return lesson;
        }

        public Task DeleteLessonById(Guid id)
        {
            db.Lesson.Remove(db.Lesson.Where(x => x.LessonId == id).FirstOrDefault());
            db.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<ICollection<Lesson>> GetLessons() => db.Lesson.ToList();

        public async Task<Lesson> GetLessonById(Guid id)
        {
            return await db.Lesson.AsNoTracking().FirstOrDefaultAsync(u => u.LessonId == id);
        }

        public Task UpdateLesson(Lesson Lesson)
        {
            db.Lesson.Update(Lesson);
            db.SaveChanges();
            return Task.CompletedTask;
        }
    }
}

