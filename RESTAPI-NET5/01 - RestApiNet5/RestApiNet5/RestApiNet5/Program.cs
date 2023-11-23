using RestApiNet5.Services.Implementations;
using RestApiNet5.Model.Context;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllers();

// Get MySQL connection string from appsettings.json
var connection = builder.Configuration["MySQLConnection:MySQLConnectionString"];

// Configure MySQLContext and register it in the service container
builder.Services.AddDbContext<MySqlContext>(options =>
    options.UseMySql(connection, new MySqlServerVersion(new Version(8, 2, 0)))
);

// Register IPersonService and its implementation
builder.Services.AddScoped<IPersonService, PersonServiceImplementation>();

var app = builder.Build();

// Configure the HTTP request pipeline.
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();

app.Run();
