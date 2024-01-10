using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Pars_ScheduleManagement.DAL.Models;
using System.IO;

namespace Pars_ScheduleManagement.DAL.Context
{
    public class ScheduleManagementDbContext : DbContext
    {
        public ScheduleManagementDbContext()
        {
        }

        public ScheduleManagementDbContext(DbContextOptions<ScheduleManagementDbContext> options) : base(options)
        {
        }

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

                var connectionString = configuration.GetConnectionString("scheduleDb");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
