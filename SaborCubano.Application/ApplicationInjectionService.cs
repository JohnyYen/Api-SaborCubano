using System;
using Microsoft.Extensions.DependencyInjection;

namespace SaborCubano.Application;

public static class ApplicationInjectionService
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services){
        services.AddMediatR(options => {
            options.RegisterServicesFromAssembly(typeof(ApplicationInjectionService).Assembly);
        });

        return services;
    }
}
