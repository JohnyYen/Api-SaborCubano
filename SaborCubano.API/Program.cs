using FastEndpoints.Swagger;
using SaborCubano.Application;
using SaborCubano.Infrastructure;
using SaborCubano.API;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();

{
    builder.Services
    .AddApplicationService()
    .AddApiServices()
    .AddInfrastructureService(builder.Configuration);

}

var app = builder.Build();
// Configure the HTTP request pipeline.

app.UseHttpsRedirection();

app.UseFastEndpoints().UseSwaggerUi();
app.UseSwaggerGen();
app.UseSwaggerUi();

app.UseAuthorization();

app.MapControllers();

app.Run();
