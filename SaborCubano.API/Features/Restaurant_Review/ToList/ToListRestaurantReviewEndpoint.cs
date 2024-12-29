using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.PlateReview;
using SaborCubano.Application.Common.DTOs.RestaurantReview;
using SaborCubano.Application.Features.PlateReview.Query.ToList;
using SaborCubano.Application.Features.RestaurantReview.Query.ToList;

namespace SaborCubano.API.Features.Restaurant_Review.ToList;

public class ToListRestaurantReviewEndpoint(IMediator mediator)
: ToListEndpoint<ResponseRestReviewDTO,ToListRestReviewQuery, RestaurantReview>
(mediator, "restaurant_review")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Restaurant Reviews"));
    }
}
