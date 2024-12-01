using System;
using api.Models;
using MediatR;
using SaborCubano.Application.Commons.Mappers;
using SaborCubano.Application.DTOs.Restaurant;
using SaborCubano.Application.Features.Restaurants.Querys.ToList;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurant.Querys.ToList;

public class ToListRestaurantHandler : IRequestHandler<ToListRestaurantQuery, IEnumerable<RestaurantDTO>>
{
    private IGenericRepository<api.Models.Restaurant> _repo = null!;

    public ToListRestaurantHandler(IGenericRepository<api.Models.Restaurant> repository){
        _repo = repository;
    }

    public Task<IEnumerable<RestaurantDTO>> Handle(ToListRestaurantQuery request, CancellationToken cancellationToken)
    {
        return Task.FromResult( _repo.GetAllAsync().ToList().Select(s => s.toRestaurantDTO()));
    }
}
