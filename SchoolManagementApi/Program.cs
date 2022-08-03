using Microsoft.EntityFrameworkCore;
using SchoolManagementApi.Data;
using SchoolManagementApi.Repository;

// Add services to the container.
var builder = WebApplication.CreateBuilder(args);

builder.Services.AddDbContext<SchoolManagementApiContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("SchoolManagementApiContext") ?? throw new InvalidOperationException("Connection string 'SchoolManagementApiContext' not found.")));
builder.Services.AddScoped(typeof(IRepo<>), typeof(Repo<>));
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
