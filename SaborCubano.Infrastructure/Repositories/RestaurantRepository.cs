using System.Linq.Expressions;
using api.Models;
using SaborCubano.Application.DTOs.Restaurant;
using SaborCubano.Application.Interfaces;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class RestaurantRepository : GenericRepository<Restaurant>
{
    public RestaurantRepository(ApplicationDBContext context) : base(context)
    {
    }
}
