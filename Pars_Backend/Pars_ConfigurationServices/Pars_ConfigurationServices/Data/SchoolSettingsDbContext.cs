using System;
using Microsoft.EntityFrameworkCore;
using Pars_ConfigurationServices.Models;

namespace Pars_ConfigurationServices.Data
{
	public class SchoolSettingsDbContext : DbContext
	{
		public SchoolSettingsDbContext(DbContextOptions<SchoolSettingsDbContext> options) : base (options)
		{

		}

        public DbSet<SchoolSettings> SchoolSettings { get; set; }
    }
}

