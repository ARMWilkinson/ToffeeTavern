using Microsoft.EntityFrameworkCore;
using ToffeeTavern.Creators;
using ToffeeTavern.Creators.Interfaces;
using ToffeeTavern.Data;
using ToffeeTavern.Deleters;
using ToffeeTavern.Deleters.Interfaces;
using ToffeeTavern.Getters;
using ToffeeTavern.Getters.Interfaces;
using ToffeeTavern.Updaters;
using ToffeeTavern.Updaters.Interfaces;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring OpenAPI at https://aka.ms/aspnet/openapi
builder.Services.AddOpenApi();
builder.Services.AddSwaggerGen();

builder.Services.AddDbContext<ToffeeContext>(options =>
{
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection"));
});

builder.Services.AddCors(options =>
{
    options.AddPolicy("Dev", policy =>
    {
        policy.AllowAnyOrigin()
              .AllowAnyMethod()
              .AllowAnyHeader();
    });
});

// Creators
builder.Services.AddScoped<ICreateNewCharacter, CreateNewCharacter>();

// Deleters
builder.Services.AddScoped<IDeleteCharacterById, DeleteCharacterById>();

// Getters
builder.Services.AddScoped<IGetAllCharacters, GetAllCharacters>();
builder.Services.AddScoped<IGetCharacterById, GetCharacterById>();

// Updaters
builder.Services.AddScoped<IUpdateCharacterById, UpdateCharacterById>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseCors("Dev");
    app.MapOpenApi();
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
