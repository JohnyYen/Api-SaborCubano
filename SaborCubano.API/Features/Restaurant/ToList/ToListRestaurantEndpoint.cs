using System;
using api.Models;
using SaborCubano.Application.DTOs.Restaurant;
using SaborCubano.Application.Features.Restaurants.Querys.ToList;

namespace SaborCubano.API.Features.Restaurant.ToList;

public class ToListEndpoint : EndpointWithoutRequest<IEnumerable<RestaurantDTO>>
{

    private readonly IMediator _mediator;
    public ToListEndpoint(IMediator mediator){
        _mediator = mediator;
    }
    public override void Configure()
    {
        Get("api/restaurant");
        AllowAnonymous();
    }

    public override Task<IEnumerable<RestaurantDTO>> ExecuteAsync(CancellationToken ct){
        
       return _mediator.Send(new ToListRestaurantQuery());
    }
}
