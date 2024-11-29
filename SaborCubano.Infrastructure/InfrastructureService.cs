using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure;

public static class InfrastructureService
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration builder){

        services.AddDbContext<ApplicationDBContext>(options => {
            options.UseNpgsql(builder.GetConnectionString("DefaultConnection"));
        });

        return services;
    }
}
