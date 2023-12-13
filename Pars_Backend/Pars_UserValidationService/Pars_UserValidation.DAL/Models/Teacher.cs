using System.ComponentModel.DataAnnotations;

namespace Pars_UserValidation.DAL.Models
{
    public class Teacher
    {
        public Guid TeacherId { get; set; }
        public string ?TeacherName { get; set; }
    }
}
