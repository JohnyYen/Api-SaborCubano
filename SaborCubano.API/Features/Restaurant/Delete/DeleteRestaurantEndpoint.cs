using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Restaurant;

namespace SaborCubano.API.Features.Restaurant.Delete;

public class DeleteRestaurantEndpoint(IMediator mediator)
: DeleteEndpoint<DeleteRestaurantRequest, ResponseRestaurantDTO, DeleteRestaurantDTO, RestaurantModel>
(mediator, "restaurant/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Restaurant"));
    }
}
