using AelimorSheetCreator.BC;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationManager config = builder.Configuration;

builder.Services.AddDbContext<AelimorContext>(options => options.UseSqlServer(config.GetConnectionString("AelimorDatabase")));

builder.Services.AddScoped<IClassRepository, ClassRepository>();
builder.Services.AddScoped<IClassBc, ClassBc>();

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
