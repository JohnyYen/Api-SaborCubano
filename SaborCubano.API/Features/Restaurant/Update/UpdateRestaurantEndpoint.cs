using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Restaurant;

namespace SaborCubano.API.Features.Restaurant.Update;

public class UpdateRestaurantEndpoint(IMediator mediator)
: UpdateEndpoint<UpdateRestaurantDTO, ResponseRestaurantDTO, RestaurantModel>(mediator, "restaurant/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Restaurant"));
    }
}
