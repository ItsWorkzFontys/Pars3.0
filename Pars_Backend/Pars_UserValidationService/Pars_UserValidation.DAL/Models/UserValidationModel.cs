using Pars_UserValidation.DAL.Enums;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Pars_UserValidation.DAL.Models
{
    public class UserValidationModel
    {
        [Key]
        public Guid UserValidationId { get; set; }
        public Guid TUId { get; set; }
        [ForeignKey("UserValidation_Lesson_FK")]
        public virtual Lesson Lesson { get; set; }
        [ForeignKey("UserValidation_Teacher_FK")]
        public virtual Teacher Teacher { get; set; }
        [ForeignKey("UserValidation_Student_FK")]
        public virtual Student Student { get; set; }
        public StudentPresence StudentPresence { get; set; }
        
    }
}
