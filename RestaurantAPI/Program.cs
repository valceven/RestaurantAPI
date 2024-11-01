using Microsoft.EntityFrameworkCore;
using RestaurantAPI.Models;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddDbContext<RestaurantDbContext>(options => 
options.UseSqlServer(builder.Configuration.GetConnectionString("DevConnection")));

builder.Services.AddControllers();

var app = builder.Build();

// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
