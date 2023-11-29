using Ocelot.Cache;
using Ocelot.DependencyInjection;
using Ocelot.Middleware;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Configuration.AddJsonFile("ocelot.json", optional: false, reloadOnChange: true);
builder.Services.AddOcelot(builder.Configuration);

// Logging
builder.Logging.ClearProviders();
builder.Logging.AddConsole();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseOcelot().Wait();

app.UseAuthorization();

app.MapControllers();

app.Run();

//using Microsoft.AspNetCore.Hosting;
//using Microsoft.AspNetCore;
//using System.Runtime.CompilerServices;

//namespace Gateway
//{
//    public class Program
//    {
//        public static void Main(string[] args)
//        {
//            BuildWebHost(args).Run();
//        }

//        public static IWebHost BuildWebHost(string[] args)
//        {
//            var builder = WebHost.CreateDefaultBuilder(args);

//            //builder.ConfigureServices(s => s.AddSingleton(builder))
//            //        .ConfigureAppConfiguration(
//            //              ic => ic.AddJsonFile(Path.Combine("app",
//            //                                                "ocelot.json")))
//            //        .UseStartup<Program>();

//            // builder.Configuration.AddJsonFile("configuration.json", optional: false, reloadOnChange: true);
//            // builder.Services.AddOcelot(builder.Configuration);

//            var host = builder.Build();
//            return host;
//        }
//    }
//}
