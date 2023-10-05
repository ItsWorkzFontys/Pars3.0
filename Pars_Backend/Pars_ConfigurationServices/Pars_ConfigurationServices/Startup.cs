using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Builder;

namespace Pars_ConfigurationServices
{
    public class Startup
    {

        public void ConfigureServices(IServiceCollection services)
        {
            services.AddSingleton<IHttpContextAccessor, HttpContextAccessor>();

            services.AddMvc();
            services.AddMvc(option => option.EnableEndpointRouting = false);
            services.AddMemoryCache();
            services.AddSession();
        }

        public void Configure(IApplicationBuilder app)
        {
            app.UseDeveloperExceptionPage();
            app.UseStatusCodePages();
            app.UseStaticFiles();
            // app.UseMvcWithDefaultRoute();
            app.UseSession();
        }
    }
}

