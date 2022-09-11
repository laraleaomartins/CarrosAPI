using CarrosAPI.Aplicacao;
using CarrosAPI.Repositorio;
using CarrosAPI.Repositorio.Generico;
using CarrosAPI.Servicos;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddDbContext<CarroContext>(x => x.UseSqlServer("Persist Security Info=False;Integrated Security=true;Initial Catalog=Carros;server=(local)"));
//Server = localhost\MSSQLSERVER01; Database = master; Trusted_Connection = True;
builder.Services.AddScoped<ICarroServico, CarroServico>();
builder.Services.AddScoped(typeof(IRepositorio<>), typeof(RepositorioGenerico<>));
builder.Services.AddAutoMapper(typeof(ConfiguracaoAutoMapper));

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
