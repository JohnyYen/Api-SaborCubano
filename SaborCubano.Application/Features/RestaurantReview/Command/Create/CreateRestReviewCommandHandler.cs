using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.RestaurantReview;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.RestaurantReview.Command.Create;

public class CreateRestReviewCommandHandler(IRestaurantReviewRepository repo, RestaurantReviewMapper mapper)
: CreateEntityCommandHandler<RestaurantReviewModel, CreateRestReviewDTO>(repo, mapper)
{

}
