using AelimorSheetCreator.BC;
using AelimorSheetCreator.Data;
using AelimorSheetCreator.Data.Repository;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

ConfigurationManager config = builder.Configuration;

builder.Services.AddDbContext<AelimorContext>(options => options.UseSqlServer(config.GetConnectionString("AelimorDatabase")));

builder.Services.AddScoped<IAttributeRepository, AttributeRepository>();
builder.Services.AddScoped<IAttributeBc, AttributeBc>();

builder.Services.AddScoped<IAttributeSkillRepository, AttributeSkillRepository>();
builder.Services.AddScoped<IAttributeSkillBc, AttributeSkillBc>();

builder.Services.AddScoped<IClassRepository, ClassRepository>();
builder.Services.AddScoped<IClassBc, ClassBc>();

builder.Services.AddScoped<ILevelRepository, LevelRepository>();
builder.Services.AddScoped<ILevelBc, LevelBc>();

builder.Services.AddScoped<IRaceRepository, RaceRepository>();
builder.Services.AddScoped<IRaceBc, RaceBc>();

builder.Services.AddScoped<IRacialSkillRepository, RacialSkillRepository>();
builder.Services.AddScoped<IRacialSkillBc, RacialSkillBc>();

builder.Services.AddScoped<ISkillRepository, SkillRepository>();
builder.Services.AddScoped<ISkillBc, SkillBc>();

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
