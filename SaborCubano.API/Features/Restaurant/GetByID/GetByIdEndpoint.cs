using System;
using SaborCubano.Application.DTOs.Restaurant;
using SaborCubano.Application.Features.Restaurants.Querys.GetById;

namespace SaborCubano.API.Features.Restaurant.GetByID;

public class GetByIdRestaurantEndpoint : Endpoint<GetByIdRequest, RestaurantDTO>
{
    public IMediator _mediator;
    public GetByIdRestaurantEndpoint(IMediator mediator){
        _mediator = mediator;
    }

    public override void Configure()
    {
        Get("api/restaurant/unique");
        AllowAnonymous();
    }

     public async override Task<RestaurantDTO> HandleAsync(GetByIdRequest request ,CancellationToken ct){
        var entity = _mediator.Send(new GetByIdRestaurantQuery(request.Id)); 
       return await entity;
    }
}
