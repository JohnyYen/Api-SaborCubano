using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Food_Type;

public class UpdateFoodTypeDTO : UpdateEntityCommandDto<FoodTypeModel>
{
    public string Name {get; set;} = null!;
}
