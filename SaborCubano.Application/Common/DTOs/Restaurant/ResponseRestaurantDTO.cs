using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Restaurant;

public class ResponseRestaurantDTO : ResponseDto<RestaurantModel>
{
    public string Name {get; set;}
}
