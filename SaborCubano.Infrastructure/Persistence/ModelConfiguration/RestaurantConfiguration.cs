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
            .HasMany(r => r.Services)
            .WithMany(s => s.Restaurants)
            .UsingEntity<Dictionary<string, object>>(
            "RestaurantService",
            j => j.HasOne<Service>().WithMany().HasForeignKey("ServiceId"),
            j => j.HasOne<Restaurant>().WithMany().HasForeignKey("RestaurantId")
        );

        builder.Entity<Restaurant>()
            .HasMany(r => r.BussinesTypes)
            .WithMany(b => b.Restaurants)
            .UsingEntity<Dictionary<string, object>>(
            "RestaurantBussinesType",
            z => z.HasOne<BussinesType>().WithMany().HasForeignKey("BussinesTypeId"),
            z => z.HasOne<Restaurant>().WithMany().HasForeignKey("RestaurantId")
        );

         builder.Entity<Restaurant>()
            .HasMany(r => r.FoodTypes)
            .WithMany(b => b.Restaurants)
            .UsingEntity<Dictionary<string, object>>(
            "RestaurantFoodType",
            y => y.HasOne<FoodType>().WithMany().HasForeignKey("FoodTypeId"),
            y => y.HasOne<Restaurant>().WithMany().HasForeignKey("RestaurantId")
        );

        builder.Entity<Restaurant>()
            .Property(a => a.Name)
            .HasMaxLength(30);


        return builder;
    }
}
