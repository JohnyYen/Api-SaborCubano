using System;
using SaborCubano.Application.Common.DTOs.Restaurant;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurant.Command.Update;

public class UpdateRestaurantCommandHandler(IRestaurantRepository repo, RestaurantMapper mapper)
: UpdateRestaurantCommandHandler<RestaurantModel, UpdateRestaurantDTO>(repo, mapper)
{

}
