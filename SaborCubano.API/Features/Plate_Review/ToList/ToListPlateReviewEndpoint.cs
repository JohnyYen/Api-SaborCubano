using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.PlateReview;
using SaborCubano.Application.Features.PlateReview.Query.ToList;

namespace SaborCubano.API.Features.Plate_Review.ToList;

public class ToListPlateReviewEndpoint(IMediator mediator)
: ToListEndpoint<ResponsePlateReviewDTO,ToListPlateReviewQuery, PlateReview>(mediator, "plate_review")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Plate Review"));
    }
}
