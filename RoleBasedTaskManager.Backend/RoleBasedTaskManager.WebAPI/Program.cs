using RoleBasedTaskManager.Infrastructure.Persistence; // Corrected syntax with a semicolon  
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

// Add services to the container.  
builder.Services.AddDbContext<AppDBContext>(options =>
   options.UseSqlServer(connectionString));
// Register the AppDBContext with the dependency injection container
builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.  

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
