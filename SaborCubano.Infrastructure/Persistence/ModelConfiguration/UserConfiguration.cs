using System;
using api.Models;

namespace SaborCubano.Infrastructure.Persistence.ModelConfiguration;

public static class UserConfiguration
{
    public static ModelBuilder AddUserConfiguration(this ModelBuilder builder){

        // builder.Entity<User>()
        //     .HasDiscriminator<string>("User_Type")
        //     .HasValue<Administrator>("Admin")
        //     .HasValue<RestaurantChief>("Chief")
        //     .HasValue<AppUser>("User");
        builder.Entity<Administrator>()
                .ToTable("Administrator");

        builder.Entity<AppUser>()
                .ToTable("AppUser");

        builder.Entity<RestaurantChief>()
                .ToTable("RestaurantChief");


        builder.Entity<User>()
            .Property(e => e.User_Name)
            .HasMaxLength(25);
        
        return builder;
    }
}
