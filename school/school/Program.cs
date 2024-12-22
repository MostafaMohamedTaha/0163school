using Microsoft.EntityFrameworkCore;
using SchoolProject.Infrastructure.Abstractes;
using SchoolProject.Infrastructure.Data;
using SchoolProject.Infrastructure;
using SchoolProject.Infrastructure.Repositories;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//add nuget EntityFrameworkCore.sqlserver
builder.Services.AddDbContext<ApplicationDBContext>(option =>
{
    option.UseSqlServer(builder.Configuration.GetConnectionString("dbcontext"));
});
//AddTransient use for create new instance of the service every time it is requested
//transient used for lignt service make new every time
//scope used for medium service make new instance for every request
//singleton used for heavy and stable service make one instance for all request
//builder.Services.AddTransient<IStudentRepository, StudentRepository>();
builder.Services.AddInfrastructureDependencies();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
