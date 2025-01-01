using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Cook_Type;

public class ResponseCookTypeDTO : ResponseDto<CookTypeModel>
{
    public string Name {get; set;} = null!;
}
