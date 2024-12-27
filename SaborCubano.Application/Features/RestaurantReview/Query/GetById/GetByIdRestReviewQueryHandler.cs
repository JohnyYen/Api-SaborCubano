using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.RestaurantReview.Query.GetById;

public class GetByIdRestReviewQueryHandler(IRestaurantReviewRepository repo, RestaurantReviewMapper mapper)
: GetByIdEntityQueryHandler<RestaurantReviewModel, GetByIdRestReviewQuery>(repo, mapper)
{

}
