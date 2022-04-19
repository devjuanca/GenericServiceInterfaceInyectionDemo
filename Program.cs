using AbstractServiceInterfaceInyectionDemo.Models;
using AbstractServiceInterfaceInyectionDemo.Services;
using Microsoft.AspNetCore.Mvc;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddScoped(typeof(IAbstractService<>), typeof(AbstractService<>));

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();



app.MapGet("/testingAbstractServiceInyectionForPlants", ([FromServices] IAbstractService<Plant> abstractService) =>
{
    return abstractService.Write(new Plant("Palm Tree", 20));
})
.WithName("testingAbstractServiceInyectionForPlants");

app.MapGet("/testingAbstractServiceInyectionForAnimals", ([FromServices] IAbstractService<Animal> abstractService) =>
{
    return abstractService.Write(new Animal("Firulais", 5));
})
.WithName("testingAbstractServiceInyectionForAnimals");

app.Run();
