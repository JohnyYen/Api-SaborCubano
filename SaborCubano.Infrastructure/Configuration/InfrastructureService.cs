using System;
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using SaborCubano.Application.Interfaces;
using SaborCubano.Infrastructure.Persistence;
using SaborCubano.Infrastructure.Repositories;
using SaborCubano.Infrastructure.Security.TokenGenerator;
using SaborCubano.Infrastructure.Security.TokenValidation;

namespace SaborCubano.Infrastructure;

public static class InfrastructureService
{
    public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration builder){

        services
        .AddPersistence(builder)
        .AddAuthentication(builder);
       
       return services;
    }


    public static IServiceCollection AddPersistence(this IServiceCollection services, IConfiguration builder){
         
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
    public static IServiceCollection AddAuthentication(this IServiceCollection services, IConfiguration configuration){

        services.Configure<JwtSettings>(configuration.GetSection(JwtSettings.Section));

        services.AddSingleton<ITokenGenerator, JwtGenerator>();

        services
        .ConfigureOptions<JwtBearerValidation>()
        .AddAuthentication(defaultScheme: JwtBearerDefaults.AuthenticationScheme)
        .AddJwtBearer();

        return services;
    }
}
