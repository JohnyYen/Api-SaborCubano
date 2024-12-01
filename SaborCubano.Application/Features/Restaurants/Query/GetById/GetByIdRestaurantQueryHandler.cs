using System;
using api.Models;
using SaborCubano.Application.DTOs.Restaurant;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurants.Querys.GetById;

public class GetByIdRestaurantQueryHandler : IRequestHandler<GetByIdRestaurantQuery, RestaurantDTO>
{
    private IGenericRepository<api.Models.Restaurant> _repo = null!;
    public async Task<RestaurantDTO> Handle(GetByIdRestaurantQuery request, CancellationToken cancellationToken)
    {
        int id = request.id;
        var entity = await _repo.GetByIdAsync(id);

        return null;
    }
}
