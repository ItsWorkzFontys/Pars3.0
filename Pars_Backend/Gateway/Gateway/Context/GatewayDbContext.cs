using Gateway.Dtos;
using Microsoft.EntityFrameworkCore;

namespace Gateway.Context
{
    public class GatewayDbContext : DbContext
    {
        public GatewayDbContext()
        {
        }

        public GatewayDbContext(DbContextOptions<GatewayDbContext> options) : base(options)
        {
        }

        public DbSet<GatewayDto> GatewayDb { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                var configuration = new ConfigurationBuilder()
                    .SetBasePath(Directory.GetCurrentDirectory())
                    .AddJsonFile("appsettings.json", optional: true) // Make the file optional
                    .Build();

                var connectionString = configuration.GetConnectionString("gatewayDb");

                optionsBuilder.UseSqlServer(connectionString);
            }
        }
    }
}
