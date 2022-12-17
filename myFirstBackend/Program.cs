// 1. Usings to work with EntityFramework
using Microsoft.EntityFrameworkCore;
using myFirstBackend.DataAccess;

var builder = WebApplication.CreateBuilder(args);

// 2. Connection with SQL
const string CONNECTION_NAME = "UniversityDB";
var connection = builder.Configuration.GetConnectionString(CONNECTION_NAME);

// 3. Add Context to Services of builder
builder.Services.AddDbContext<UniversityDBContext>(options => options.UseSqlServer(connection));



// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

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