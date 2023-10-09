using System.ComponentModel.DataAnnotations;


namespace Pars_UserValidation.DAL.Models
{
    public class UserValidationModel
    {
        [Key]
        public Guid UserValidationId { get; set; }
    }
}
