using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurant.Query.GetById;

public class GetByIdRestaurantQueryHandler(IRestaurantRepository repo, RestaurantMapper mapper)
: GetByIdEntityQueryHandler<RestaurantModel, GetByIdRestaurantQuery>(repo, mapper)
{

}
