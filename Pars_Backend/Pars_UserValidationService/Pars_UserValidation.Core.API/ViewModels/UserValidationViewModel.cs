using System.ComponentModel.DataAnnotations;

namespace Pars_UserValidation.Core.API.ViewModels
{
    public class UserValidationViewModel
    {
        [Key]
        public Guid UserValidationId { get; set; }
    }
}
