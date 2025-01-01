using System;
using Microsoft.Extensions.DependencyInjection;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Mappers;

namespace SaborCubano.Application;

public static class ApplicationInjectionService
{
    public static IServiceCollection AddApplicationService(this IServiceCollection services){
        services.AddMediatR(options => {
            options.RegisterServicesFromAssembly(typeof(ApplicationInjectionService).Assembly);
        });

        services.AddMappers();
        return services;
    }

    public static IServiceCollection AddMappers(this IServiceCollection services){

        services.AddTransient<ServiceMapper>();
        services.AddTransient<BussinesTypeMapper>();
        services.AddTransient<FoodTypeMapper>();
        services.AddTransient<RestaurantMapper>();
        services.AddTransient<CookTypeMapper>();
        services.AddTransient<PlateReviewMapper>();
        services.AddTransient<RestaurantReviewMapper>();
        services.AddTransient<CoordinatesMapper>();
        services.AddTransient<IngredientMapper>();

        return services;
    }
}
