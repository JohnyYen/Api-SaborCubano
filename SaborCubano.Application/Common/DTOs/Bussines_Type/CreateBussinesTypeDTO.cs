using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Bussines_Type;

public class CreateBussinesTypeDTO : CreateEntityCommandDto<BussinesType>
{
    public String Name {get; set;} = null!;
}
