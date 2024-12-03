using System;

namespace SaborCubano.API;

public static class APIServices
{
    public static IServiceCollection AddApiServices(this IServiceCollection services){

        services.AddControllers();
        services.AddEndpointsApiExplorer();
        services.AddProblemDetails();
        services.AddFastEndpoints();

        return services;
    }
}
