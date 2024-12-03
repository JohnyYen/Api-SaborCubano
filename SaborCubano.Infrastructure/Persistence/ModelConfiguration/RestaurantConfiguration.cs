using System;
using api.Models;

namespace SaborCubano.Infrastructure.Persistence.ModelConfiguration;

public static class RestaurantConfiguration
{
    public static ModelBuilder AddRestaurantConfiguration (this ModelBuilder builder){

        builder.Entity<Restaurant>()
            .Property(e => e.Direction)
            .HasMaxLength(50);

        builder.Entity<Restaurant>()
            .Property(a => a.Name)
            .HasMaxLength(30);


        return builder;
    }
}
