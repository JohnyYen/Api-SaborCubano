using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.PlateReview;
using SaborCubano.Application.Common.DTOs.RestaurantReview;

namespace SaborCubano.API.Features.Restaurant_Review.Delete;

public class DeleteRestaurantReviewEndpoint(IMediator mediator)
: DeleteEndpoint<DeleteRestReviewRequest, ResponseRestReviewDTO, DeleteRestReviewDTO, RestaurantReview>
(mediator, "restaurant_review/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Restaurant Reviews"));
    }
}
