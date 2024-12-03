using System;
using api.Models;

namespace SaborCubano.Infrastructure.Persistence.ModelConfiguration;

public static class ReviewConfiguration
{
    public static ModelBuilder AddReviewConfiguration(this ModelBuilder builder){

        builder.Entity<Review>()
            .HasDiscriminator<string>("Review_Type")
            .HasValue<RestaurantReview>("Restaurant")
            .HasValue<PlateReview>("Plate");

        builder.Entity<Review>()
            .Property(e => e.Name)
            .HasMaxLength(30);

        builder.Entity<Review>()
            .Property(a => a.Opinion)
            .HasMaxLength(240);

                
        return builder;
    }
}
