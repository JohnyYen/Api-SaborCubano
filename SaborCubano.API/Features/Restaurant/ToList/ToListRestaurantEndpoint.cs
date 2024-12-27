using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Restaurant;
using SaborCubano.Application.Features.Restaurant.Query.ToList;

namespace SaborCubano.API.Features.Restaurant.ToList;

public class ToListRestaurantEndpoint(IMediator mediator):
ToListEndpoint<ResponseRestaurantDTO, ToListRestaurantQuery, RestaurantModel>(mediator, "restaurant")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Restaurant"));
    }
}
