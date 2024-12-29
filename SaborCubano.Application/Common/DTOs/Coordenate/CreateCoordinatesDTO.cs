using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain.Models;

namespace SaborCubano.Application.Common.DTOs.Coordenate;

public class CreateCoordinatesDTO : CreateEntityCommandDto<Coordinates>
{
    public int Id_Res{get; set;}
    public float Longitude {get; set;}
    public float Latitude {get; set;}
}
