using Microsoft.EntityFrameworkCore;
using Pars_ConfigurationServices.Data;
using Pars_ConfigurationServices.Services;

namespace Pars_ConfigurationServices
{
    public class Startup
    {
        public IConfiguration Configuration { get; }
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddScoped<ConfigurationService>();

            services.AddEndpointsApiExplorer();
            services.AddHttpClient();
            services.AddControllers();
            services.AddSession();
            services.AddDistributedMemoryCache();
            services.AddHttpContextAccessor();

            services.AddDbContext<ApplicationDbContext>(options =>
            options.UseMySql(Configuration.GetConnectionString("ConfigurationSettings"), new MySqlServerVersion(new Version(8, 1, 0))));

            services.AddSwaggerGen();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            app.UseSession();
            app.UseRouting();

            app.UseSwagger();
            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "Configuration Service API V1");
                c.RoutePrefix = string.Empty; // This can be any route you prefer
            });

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });

            app.Use(async (context, next) =>
            {
                if (context.Request.Path == "/")
                {
                    context.Response.Redirect("/swagger");
                    return;
                }

                await next();
            });
        }
    }
}

