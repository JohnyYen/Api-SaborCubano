using System;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaborCubano.Application.Interfaces;
using SaborCubano.Infrastructure.Persistence;
using SaborCubano.Infrastructure.Repositories;

namespace SaborCubano.Infrastructure;

public static class InfrastructureService
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration builder){

        services.AddDbContext<ApplicationDBContext>(options => {
            options.UseNpgsql(builder.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped(typeof(IGenericRepository<>), typeof(GenericRepository<>));
        services.AddScoped<IRestaurantRepository, RestaurantRepository>();
        services.AddScoped<IServiceRepository, ServiceRepository>();
        services.AddScoped<IFoodTypesRepository, FoodTypesRepository>();
        services.AddScoped<IBussinesRepository, BussinesRepository>();
        services.AddScoped<ICookTypeRepository, CookTypeRepository>();
        
        return services;
    }
}
