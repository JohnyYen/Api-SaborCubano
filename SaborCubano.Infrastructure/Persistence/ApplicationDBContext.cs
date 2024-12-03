using System;
using System.Reflection;
using api.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using SaborCubano.Infrastructure.Persistence.ModelConfiguration;

namespace SaborCubano.Infrastructure.Persistence;

public class ApplicationDBContext : IdentityDbContext<User>
{
    public virtual DbSet<Restaurant> Restaurants {get; set;} = null!;
    public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options){
        
    }

    public DbSet<TModel> GetDbSet<TModel>() where TModel : class{
        return Set<TModel>();
    }

    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    {
        base.OnConfiguring(optionsBuilder);
        optionsBuilder.UseNpgsql("HOST=Localhost;USERNAME=postgres;Database=SaborCubano;PORT=5432;PASSWORD=0403");
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        builder.ApplyConfigurationsFromAssembly(typeof(ApplicationDBContext).Assembly);

        base.OnModelCreating(builder);
        builder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

        builder.AddRestaurantConfiguration();
        builder.AddReviewConfiguration();    
        builder.AddUserConfiguration();      
        builder.AddCouponConfiguration();    


    }
}
