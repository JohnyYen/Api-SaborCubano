using System;
using api.Models;
using Microsoft.Extensions.Configuration;

namespace SaborCubano.Infrastructure.Persistence;

public class ApplicationDBContext : DbContext
{
    public virtual DbSet<Restaurant> Restaurants {get; set;}
    public ApplicationDBContext(DbContextOptions options) : base(options){
        
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);
        
       
    }
}
