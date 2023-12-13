using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Pars_UserValidation.DAL.Models;
using Pars_UserValidation.DAL.Services;

namespace Pars_UserValidation.Core.API.Services
{
    public class UserValidationCore : IUserValidationService
    {
        private readonly IUserValidationDAL _userValidationDAL;
        public UserValidationCore(IUserValidationDAL userValidationDAL)
        {
            _userValidationDAL = userValidationDAL;
        }

        public async Task<UserValidationModel> AddUserValidation(UserValidationModel uservalidation)
        {
            return await _userValidationDAL.AddUserValidation(uservalidation);      
        }

        public Task DeleteUserValidationById(Guid id)
        {
            return _userValidationDAL.DeleteUserValidationById(id);
        }

        public async Task<ICollection<UserValidationModel>> GetUserValidations()
        {
            return await _userValidationDAL.GetUserValidations();
        }

        public async Task<UserValidationModel> GetValidationById(Guid id)
        {
            return await _userValidationDAL.GetValidationById(id);
        }

        public async Task UpdateUserValidation(UserValidationModel uservalidation)
        {
            await _userValidationDAL.UpdateUserValidation(uservalidation);
        }
    }
}
