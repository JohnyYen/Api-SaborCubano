using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.PlateReview;

namespace SaborCubano.API.Features.Plate_Review.Update;

public class UpdatePlateReviewEndpoint(IMediator mediator)
: UpdateEndpoint<UpdatePlateReviewDTO, ResponsePlateReviewDTO, PlateReview>(mediator, "plate_review/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Plate Review"));
    }
}
