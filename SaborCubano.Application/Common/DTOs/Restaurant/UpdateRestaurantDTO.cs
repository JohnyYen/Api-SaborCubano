using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Restaurant;

public class UpdateRestaurantDTO : UpdateEntityCommandDto<RestaurantModel>
{
    public string Name {get; set;}
}
