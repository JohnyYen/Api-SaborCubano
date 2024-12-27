using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Restaurant;
using SaborCubano.Application.Features.Restaurant.Query.GetById;

namespace SaborCubano.API.Features.Restaurant.GetById;

public class GetByIdRestaurantEndpoint(IMediator mediator)
: GetByIdEndpoint<GetByIdRestaurantRequest, ResponseRestaurantDTO, RestaurantModel, GetByIdRestaurantQuery>
(mediator, "restaurant/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Restaurant"));
    }
}
