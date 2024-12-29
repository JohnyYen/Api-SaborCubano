using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.PlateReview;
using SaborCubano.Application.Features.PlateReview.Query.GetById;

namespace SaborCubano.API.Features.Plate_Review.GetById;

public class GetByIdPlateReviewEndpoint(IMediator mediator)
: GetByIdEndpoint<GetByIdPlateReviewRequest, ResponsePlateReviewDTO, PlateReview, GetByIdPlateReviewQuery>
(mediator, "plate_review/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Food Types"));
    }
}
