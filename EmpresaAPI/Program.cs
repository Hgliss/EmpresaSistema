using Microsoft.EntityFrameworkCore;
using EmpresaAPI.Data;
using EmpresaAPI.Repositories;
using EmpresaAPI.Services;
using EmpresaAPI.Helpers;


var builder = WebApplication.CreateBuilder(args);

string connectionString = ConnectionHelper.GetConnectionString();

builder.Services.AddDbContext<EmpresaContext>(options  => options.UseSqlServer(connectionString));

// Add services to the container.

builder.Services.AddControllers();

// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

//Agregar Servicios
builder.Services.AddScoped<ClienteRepository>();
builder.Services.AddScoped<ClienteService>();
builder.Services.AddScoped<DepartamentoRepository>();
builder.Services.AddScoped<DepartamentoService>();
builder.Services.AddScoped<DetalleVentaRepository>();
builder.Services.AddScoped<DetalleVentaService>();

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
