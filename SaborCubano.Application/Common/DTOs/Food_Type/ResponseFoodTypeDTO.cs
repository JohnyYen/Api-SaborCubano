using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Food_Type;

public class ResponseFoodTypeDTO : ResponseDto<FoodTypeModel>
{
    public string Name {get; set;} = null!;
}
