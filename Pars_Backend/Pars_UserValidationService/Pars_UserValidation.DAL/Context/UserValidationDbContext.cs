using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pars_UserValidation.DAL.Models;

namespace Pars_UserValidation.DAL.Context
{
    public class UserValidationDbContext : DbContext
    {
        public UserValidationDbContext()
        {

        }

        public UserValidationDbContext(DbContextOptions<UserValidationDbContext> options) : base(options)
        {

        }

        public DbSet<UserValidationModel> validationDb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            var configuration = new ConfigurationBuilder()
                .SetBasePath(Directory.GetCurrentDirectory())
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("validationDb");

            optionsBuilder.UseSqlServer(connectionString);
        }
    }
}
