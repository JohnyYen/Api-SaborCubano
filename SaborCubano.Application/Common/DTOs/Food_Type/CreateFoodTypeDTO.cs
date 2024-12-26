using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Food_Type;

public class CreateFoodTypeDTO : CreateEntityCommandDto<FoodTypeModel>
{
    public string Name{get; set;} = null!;
}
