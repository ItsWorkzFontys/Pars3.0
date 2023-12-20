using Microsoft.EntityFrameworkCore;
using Pars_UserValidation.Core.API.Services;
using Pars_UserValidation.DAL.Context;
using Pars_UserValidation.DAL.Models;
using Pars_UserValidation.DAL.Services;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("validationDb");
// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<UserValidationDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddTransient<IUserValidationDAL, UserValidationDAL>();
builder.Services.AddTransient<IUserValidationService, UserValidationCore>();

var app = builder.Build();

using (IServiceScope? scope = app.Services.CreateScope())
{
    UserValidationDbContext UserValidationDbContext = scope.ServiceProvider.GetRequiredService<UserValidationDbContext>();
    UserValidationDbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

// Cors
app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
