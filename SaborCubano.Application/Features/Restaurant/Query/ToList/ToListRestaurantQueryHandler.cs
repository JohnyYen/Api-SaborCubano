using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Restaurant.Query.ToList;

public class ToListRestaurantQueryHandler
(IRestaurantRepository repo, RestaurantMapper mapper)
:ToListEntityQueryHandler<RestaurantModel, ToListRestaurantQuery>(repo, mapper)
{

}