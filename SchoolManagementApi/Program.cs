using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using SchoolManagementApi.Data;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddDbContext<SchoolManagementApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolManagementApiContext") ?? throw new InvalidOperationException("Connection string 'SchoolManagementApiContext' not found.")));

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
//builder.Services.AddDbContext<DbContext>(options => options.UseSqlServer(ConfigurationBinder.Get(ConnectionInfo<>)));
var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();
app.UseAuthentication();

app.UseAuthorization();

app.MapControllers();

app.Run();
