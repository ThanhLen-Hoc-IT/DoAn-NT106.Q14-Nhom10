using Microsoft.EntityFrameworkCore;
using UniGate.Api.Configurations;
using UniGate.Api.ModelFromDB;
using UniGate.Infrastructure.Data;

var builder = WebApplication.CreateBuilder(args);

// ============================
// 1) Add DbContext
// ============================
builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"))
);

// ============================
// 2) Add Controllers
// ============================
builder.Services.AddControllers();

// ============================
// 3) Swagger
// ============================
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

// ============================
// 4) CORS cho phép upload file
// ============================
builder.Services.AddCors(options =>
{
    options.AddPolicy("AllowAll", b =>
        b.AllowAnyOrigin()
         .AllowAnyMethod()
         .AllowAnyHeader());
});

IConfigurationRoot cf = new ConfigurationBuilder().SetBasePath(AppDomain.CurrentDomain.BaseDirectory).AddJsonFile("appsettings.json", optional: false, reloadOnChange: true).Build();
builder.Services.AddDbContext<CSDL_DOANContext>(opt => opt.UseSqlServer(cf.GetConnectionString("cnn")));
var app = builder.Build();

// ============================
// 5) Middleware
// ============================
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.MapControllers();
app.Run();
