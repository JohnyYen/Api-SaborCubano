using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Review;

namespace SaborCubano.Application.Common.DTOs.PlateReview;

public class UpdatePlateReviewDTO : UpdateEntityCommandDto<PlateReviewModel>
{
    public string Description {get; set;}
}
