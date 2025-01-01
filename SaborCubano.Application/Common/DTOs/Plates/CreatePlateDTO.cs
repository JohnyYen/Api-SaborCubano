using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Plates;

public class CreatePlateDTO : CreateEntityCommandDto<PlateModel>
{
    public string Name {get; set;} = null!;

    public string Description {get; set;} = null!;

    public float Price {get; set;}

    public float Calories {get; set;}

}
