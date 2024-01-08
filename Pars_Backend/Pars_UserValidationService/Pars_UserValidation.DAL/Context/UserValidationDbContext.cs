using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pars_UserValidation.DAL.Models;
using System.IO;

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

        public DbSet<UserValidationModel> UserValidation { get; set; }
        public DbSet<Teacher> Teacher { get; set; }
        public DbSet<Student> Student { get; set; }
        public DbSet<Lesson> Lesson { get; set; }
        public DbSet<ClassRoom> Classroom { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true) // Make the file optional
                    .Build();

                var connectionString = configuration.GetConnectionString("validationDb");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
