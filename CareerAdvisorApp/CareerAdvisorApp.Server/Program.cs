using Microsoft.EntityFrameworkCore;
using CareerAdvisorApp.Server.ModelFromDB;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();

IConfiguration cf = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json", optional:false, reloadOnChange:true).Build();
builder.Services.AddDbContext<CSDL_DOANContext>(opt => opt.UseSqlServer(cf.GetConnectionString("cnn")));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.MapOpenApi();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
