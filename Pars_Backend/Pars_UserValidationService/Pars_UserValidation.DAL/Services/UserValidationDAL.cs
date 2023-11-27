﻿using Pars_UserValidation.DAL.Context;
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

        public async Task AddUserValidation(UserValidationModel uservalidation)
        {
            await db.ValidationDb.AddAsync(uservalidation);
            db.SaveChanges();
        }

        public Task DeleteUserValidationById(Guid id)
        {
            db.ValidationDb.Remove(db.ValidationDb.Where(x => x.UserValidationId == id).FirstOrDefault());
            db.SaveChanges();
            return Task.CompletedTask;
        }

        public async Task<ICollection<UserValidationModel>> GetUserValidations() => db.ValidationDb.ToList();

        public async Task<UserValidationModel> GetValidationById(Guid id)
        {
            return await db.ValidationDb.AsNoTracking().FirstOrDefaultAsync(u => u.UserValidationId == id);
        }

        public Task UpdateUserValidation(UserValidationModel uservalidation)
        {
            db.ValidationDb.Update(uservalidation);
            db.SaveChanges();
            return Task.CompletedTask;
        }
    }
}

