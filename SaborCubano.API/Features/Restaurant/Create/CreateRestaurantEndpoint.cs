using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Common.DTOs.Restaurant;

namespace SaborCubano.API.Features.Restaurant.Create;

public class CreateRestaurantEndpoint(IMediator mediator)
:CreateEndpoint<CreateRestaurantDTO, ResponseRestaurantDTO, RestaurantModel>(mediator, "restaurant")
{
    public override void AddConfiguration()
    {

        Description(x => x.WithTags("Restaurant"));
    }
}