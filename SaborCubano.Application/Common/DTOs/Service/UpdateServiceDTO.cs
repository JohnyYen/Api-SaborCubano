using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Service;

public class UpdateServiceDTO : UpdateEntityCommandDto<ServiceModel>
{
    public string Name {get; set;} = null!;
}
