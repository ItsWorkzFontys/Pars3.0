using Pars_UserValidation.DAL.Models;

namespace Pars_UserValidation.DAL.Services
{
    public interface IUserValidationDAL
    {
        Task<UserValidationModel> AddUserValidation(UserValidationModel uservalidation);
        Task<ICollection<UserValidationModel>> GetUserValidations();
        Task UpdateUserValidation(UserValidationModel uservalidation);
        Task<UserValidationModel> GetValidationById(Guid id);
        Task DeleteUserValidationById(Guid id);
    }
}
