using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Review;

namespace SaborCubano.Application.Common.DTOs.RestaurantReview;

public class UpdateRestReviewDTO : UpdateEntityCommandDto<RestaurantReviewModel>
{
    public string Description {get; set;}
}
