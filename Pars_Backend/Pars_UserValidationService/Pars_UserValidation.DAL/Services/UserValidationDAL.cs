using Pars_UserValidation.DAL.Context;
using Pars_UserValidation.DAL.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.ObjectModel;

namespace Pars_UserValidation.DAL.Services
{
    public class UserValidationDAL : IUserValidationDAL
    {
        private readonly UserValidationDbContext db;

        public UserValidationDAL(UserValidationDbContext db)
        {
            this.db = db;
        }

        public async Task<UserValidationModel> AddUserValidation(UserValidationModel uservalidation)
        {
            db.UserValidation.Add(uservalidation);
            await db.SaveChangesAsync();
            return uservalidation;
        }

        public Task DeleteUserValidationById(Guid id)
        {
            db.UserValidation.Remove(db.UserValidation.Where(x => x.UserValidationId == id).FirstOrDefault());
            db.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<ICollection<UserValidationModel>> GetUserValidations() => db.UserValidation.ToList();

        public async Task<UserValidationModel> GetValidationById(Guid id)
        {
            return await db.UserValidation.AsNoTracking().FirstOrDefaultAsync(u => u.UserValidationId == id);
        }

        public Task UpdateUserValidation(UserValidationModel uservalidation)
        {
            db.UserValidation.Update(uservalidation);
            db.SaveChanges();
            return Task.CompletedTask;
        }
    }
}

