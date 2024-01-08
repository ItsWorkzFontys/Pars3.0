using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Runtime.CompilerServices;

namespace Pars_UserValidation.DAL.Models
{
    public class Lesson
    {
        public Guid LessonId { get; set; }
        public ClassRoom ?classRoom { get; set; }
        public Teacher ?Teacher { get; set; }
        public List<Student> ?students { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set;}
    }
}
