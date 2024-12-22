using System;
using FastEndpoints.Swagger;

namespace SaborCubano.API;

public static class APIServices
{
    public static IServiceCollection AddApiServices(this IServiceCollection services){
        
        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddProblemDetails();
        services.AddFastEndpoints()
        .SwaggerDocument();

        return services;
    }
}
