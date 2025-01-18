using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Cook_Type;
using SaborCubano.Application.Common.DTOs.Ingredient;

namespace SaborCubano.Application.Common.DTOs.Plates;

public class ResponsePlateDTO : ResponseDto<PlateModel>
{
    public string Name {get; set;} = null!;

    public string Description {get; set;} = null!;

    public float Price {get; set;}

    public float Calories {get; set;}

    public IEnumerable<ResponseIngredientDTO> Ingredient {get; set;} = null!;

    public IEnumerable<ResponseCookTypeDTO> CookType {get; set;} = null!;
}
