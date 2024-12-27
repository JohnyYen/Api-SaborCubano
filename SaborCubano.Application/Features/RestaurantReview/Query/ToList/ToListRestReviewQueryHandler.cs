using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.RestaurantReview.Query.ToList;

public class ToListRestReviewQueryHandler(IRestaurantReviewRepository repo, RestaurantReviewMapper mapper)
: ToListEntityQueryHandler<RestaurantReviewModel, ToListRestReviewQuery>(repo, mapper)
{

}
