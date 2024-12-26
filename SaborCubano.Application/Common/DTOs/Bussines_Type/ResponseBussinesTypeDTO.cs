using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Bussines_Type;

public class ResponseBussinesTypeDTO : ResponseDto<BussinesType>
{
    public string Name {get; set;} = null!;
}
