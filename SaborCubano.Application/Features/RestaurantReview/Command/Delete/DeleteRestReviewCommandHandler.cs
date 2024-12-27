using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.RestaurantReview;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.RestaurantReview.Command.Delete;

public class DeleteRestReviewCommandHandler(IRestaurantReviewRepository repo, RestaurantReviewMapper mapper)
: DeleteEntityCommandHandler<RestaurantReviewModel, DeleteRestReviewDTO>(repo, mapper)
{

}
