using UniGate.Api.Configurations;

var builder = WebApplication.CreateBuilder(args);

// Add services
builder.Services.AddControllers();

// Cấu hình Swagger
builder.Services.AddSwaggerConfig();

// CORS
builder.Services.AddCorsConfig();

// JWT config
builder.Services.Configure<JwtConfig>(builder.Configuration.GetSection("Jwt"));

// Build app
var app = builder.Build();

// Middleware
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI(c => c.SwaggerEndpoint("/swagger/v1/swagger.json", "UniGate API v1"));
}

app.UseCors("AllowAll");
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
