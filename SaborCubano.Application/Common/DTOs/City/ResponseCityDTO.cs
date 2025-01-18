using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.City;

public class ResponseCityDTO : ResponseDto<CityModel>
{
    public string Name {get; set;} = null!;
}
