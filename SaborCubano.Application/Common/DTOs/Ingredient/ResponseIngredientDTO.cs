using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Ingredient;

public class ResponseIngredientDTO : ResponseDto<IngredientModel>
{
    public string Name {get; set;} = null!;
}
