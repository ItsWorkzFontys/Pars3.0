using Pars_UserValidation.DAL.Models;

namespace Pars_UserValidation.Core.API.Services
{
    public interface IUserValidationService
    {
        Task AddUserValidation(UserValidationModel uservalidation);
        Task<ICollection<UserValidationModel>> GetUserValidations();
        Task UpdateUserValidation(UserValidationModel uservalidation);
        Task<UserValidationModel> GetValidationById(Guid id);
        Task DeleteUserValidationById(Guid id);
    }
}
