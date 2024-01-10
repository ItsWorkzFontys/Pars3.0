using Pars_ScheduleManagement.Core.API.Services;
using Pars_ScheduleManagement.DAL.Services;
using Pars_ScheduleManagement.DAL.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("scheduleDb");

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<ScheduleManagementDbContext>(options => options.UseSqlServer(connectionString));
builder.Services.AddTransient<ILessonDAL, LessonDAL>();
builder.Services.AddTransient<ILessonService, LessonCore>();

var app = builder.Build();

using (IServiceScope? scope = app.Services.CreateScope())
{
    ScheduleManagementDbContext ScheduleManagementDbContext = scope.ServiceProvider.GetRequiredService<ScheduleManagementDbContext>();
    ScheduleManagementDbContext.Database.Migrate();
}

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors(x => x
    .AllowAnyOrigin()
    .AllowAnyMethod()
    .AllowAnyHeader());

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
