using Pars_UserValidation.DAL.Context;
using Pars_UserValidation.DAL.Models;
using Microsoft.EntityFrameworkCore;

namespace Pars_UserValidation.DAL.Services
{
    public class UserValidationDAL : IUserValidationDAL
    {
        private readonly UserValidationDbContext db;

        public UserValidationDAL(UserValidationDbContext db)
        {
            this.db = db;
        }

        public async Task AddUserValidation(UserValidationModel uservalidation)
        {
            await db.UserValidation_Db.AddAsync(uservalidation);
            db.SaveChanges();
        }

        public Task DeleteUserValidationById(Guid id)
        {
            db.UserValidation_Db.Remove(db.UserValidation_Db.Where(x => x.UserValidationId == id).FirstOrDefault());
            db.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<ICollection<UserValidationModel>> GetUserValidations() => db.UserValidation_Db.ToList();

        public Task<UserValidationModel> GetValidationById(Guid id)
        {
            throw new NotImplementedException();
        }

        public Task UpdateUserValidation(UserValidationModel uservalidation)
        {
            throw new NotImplementedException();
        }
    }
}

