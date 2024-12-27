using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Restaurant;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurant.Command.Delete;

public class DeleteRestaurantCommandHandler(IRestaurantRepository repo, RestaurantMapper mapper)
: DeleteEntityCommandHandler<RestaurantModel, DeleteRestaurantDTO>(repo, mapper)
{

}
