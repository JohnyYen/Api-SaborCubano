using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Service;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class ServiceMapper : IMapper<ServiceModel>
{
    public ResponseDto<Service> toDto(Service model)
    {
        return new ResponseServiceDTO {
            Id = model.Id,
            Name = model.Name
        };
    }

    public Service toModel(CreateEntityCommandDto<Service> dto)
    {
        var serviceDto = (CreateServiceDTO)dto;

        return new Service{
            Name = serviceDto.Name
        };
    }

    public Service toModel(UpdateEntityCommandDto<Service> dto, BaseEntity model)
    {
        var thisModel = (Service)model;
        var thisDto = (UpdateServiceDTO)dto;
        
        thisModel.Name = thisDto.Name;
        return thisModel;
    }
}
