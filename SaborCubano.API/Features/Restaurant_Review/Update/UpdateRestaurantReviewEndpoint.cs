using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.PlateReview;
using SaborCubano.Application.Common.DTOs.RestaurantReview;

namespace SaborCubano.API.Features.Restaurant_Review.Update;

public class UpdateRestaurantReviewEndpoint(IMediator mediator)
: UpdateEndpoint<UpdateRestReviewDTO, ResponseRestReviewDTO, RestaurantReview>
(mediator, "restaurant_review/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Restaurant Reviews"));
    }
}
