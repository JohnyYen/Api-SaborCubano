using System;
using api.Models;
using MediatR;
using SaborCubano.Application.DTOs.Restaurant;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurant.Querys.ToList;

public class ToListRestaurantHandler : IRequestHandler<ToListRestaurantQuery, IEnumerable<RestaurantDTO>>
{
    private IGenericRepository<api.Models.Restaurant> _repo = null!;

    public ToListRestaurantHandler(IGenericRepository<api.Models.Restaurant> repository){
        _repo = repository;
    }

    public async Task<IEnumerable<RestaurantDTO>> Handle(ToListRestaurantQuery request, CancellationToken cancellationToken)
    {
        return null;
        //return await _repo.GetAllAsync(null);
    }
}
