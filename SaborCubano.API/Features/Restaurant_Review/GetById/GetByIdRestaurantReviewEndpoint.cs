using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.PlateReview;
using SaborCubano.Application.Common.DTOs.RestaurantReview;
using SaborCubano.Application.Features.PlateReview.Query.GetById;
using SaborCubano.Application.Features.RestaurantReview.Query.GetById;

namespace SaborCubano.API.Features.Restaurant_Review.GetById;

public class GetByIdRestaurantReviewEndpoint(IMediator mediator)
: GetByIdEndpoint<GetByIdRestReviewRequest, ResponseRestReviewDTO, RestaurantReview, GetByIdRestReviewQuery>
(mediator, "restaurant_review/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Restaurant Reviews"));
    }
}
