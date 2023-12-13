using Pars_UserValidation.DAL.Enums;
using System.ComponentModel.DataAnnotations;

namespace Pars_UserValidation.DAL.Models
{
    public class UserValidationModel
    {
        [Key]
        public Guid UserValidationId { get; set; }
        public Guid TUId { get; set; }
        public Lesson Lesson { get; set; }
        public Teacher Teacher { get; set; }
        public Student Student { get; set; }
        public StudentPresence StudentPresence { get; set; }
        
    }
}
