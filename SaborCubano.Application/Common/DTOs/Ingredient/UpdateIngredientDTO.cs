using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Ingredient;

public class UpdateIngredientDTO : UpdateEntityCommandDto<IngredientModel>
{
    public string Name {get; set;} = null!;
}
