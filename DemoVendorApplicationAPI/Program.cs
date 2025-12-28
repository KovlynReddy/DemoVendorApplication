using DemoVendorApplicationAPI.DataAccess.DB;
using DemoVendorApplicationAPI.DataAccess.Repository;
using DemoVendorApplicationAPI.Interfaces.DataAccess.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
var connectionString = builder.Configuration.GetConnectionString("DefaultConnection");

builder.Services.AddDbContext<VendorDBContext>(options =>
    options.UseSqlServer(connectionString));

builder.Services.AddScoped<IVendorRepository, VendorRepository>();
builder.Services.AddScoped<IItemRepository, ItemRepository>();

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
