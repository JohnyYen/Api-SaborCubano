using api.Models;
using SaborCubano.Application.Interfaces;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class RestaurantRepository : GenericRepository<Restaurant>, IRestaurantRepository
{
    public RestaurantRepository(ApplicationDBContext context) : base(context)
    {
    }
}
