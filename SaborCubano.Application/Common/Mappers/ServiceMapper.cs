using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Service;
using SaborCubano.Application.Interfaces.Mappers;

namespace SaborCubano.Application.Common.Mappers;

public class ServiceMapper : IMapper<ServiceModel>
{
    public ResponseDto<Service> toDto(Service model)
    {
        return new ResponseServiceDTO {
            Name = model.Name
        };
    }

    public Service toModel(CreateEntityCommandDto<Service> dto)
    {
        throw new NotImplementedException();
    }

    public Service toModel(UpdateEntityCommandDto<Service> dto)
    {
        throw new NotImplementedException();
    }
}
