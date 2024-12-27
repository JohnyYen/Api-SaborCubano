using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.RestaurantReview;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.RestaurantReview.Command.Update;

public class UpdateRestReviewCommandHandler(IRestaurantReviewRepository repo, RestaurantReviewMapper mapper)
: UpdateEntityCommandHandler<RestaurantReviewModel, UpdateRestReviewDTO>(repo, mapper)
{

}
