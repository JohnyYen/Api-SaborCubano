using System;
using api.Models;
using Microsoft.Extensions.Configuration;

namespace SaborCubano.Infrastructure.Persistence;

public class ApplicationDBContext : DbContext
{
    public virtual DbSet<Restaurant> Restaurants {get; set;} = null!;
    public ApplicationDBContext(DbContextOptions options) : base(options){
        
    }

    public DbSet<TModel> GetDbSet<TModel>() where TModel : class{
        return Set<TModel>();
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
       
    }
}
