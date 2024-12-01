using System;
using api.Models;
using SaborCubano.Application.Commons.Mappers;
using SaborCubano.Application.DTOs.Restaurant;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurants.Querys.GetById;

public class GetByIdRestaurantQueryHandler : IRequestHandler<GetByIdRestaurantQuery, RestaurantDTO>
{
    private IRestaurantRepository _repo = null!;


    public GetByIdRestaurantQueryHandler(IRestaurantRepository repository){
        _repo = repository;
    }
    public async Task<RestaurantDTO> Handle(GetByIdRestaurantQuery request, CancellationToken cancellationToken)
    {
        int id = request.id;
        var entity = await _repo.GetByIdAsync(id);
        if (entity == null)
            throw new Exception("RESTAURANT_NOT_FOUND");
        return entity.toRestaurantDTO();
    }
}
