using System;
using SaborCubano.Application.DTOs.Restaurant;

namespace SaborCubano.API.Features.Restaurant.GetByID;

public class GetByIdRestaurantEndpoint : Endpoint<GetByIdRequest, RestaurantDTO>
{
    public IMediator _mediator;
    public GetByIdRestaurantEndpoint(IMediator mediator){
        _mediator = mediator;
    }

    public override void Configure()
    {
        Get("api/restaurant");
        AllowAnonymous();
    }

    
}
