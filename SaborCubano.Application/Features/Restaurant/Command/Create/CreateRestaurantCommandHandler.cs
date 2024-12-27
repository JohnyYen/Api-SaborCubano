using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurant.Command.Create;

public class CreateRestaurantCommandHandler
(IRestaurantRepository repo, RestaurantMapper mapper)
: CreateEntityCommandHandler<RestaurantModel, CreateRestaurantDTO>(repo, mapper)
{

}
