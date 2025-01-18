using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Service;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Service.Command.Create;

public class CreateServiceCommandHandler
(IServiceRepository repo, ServiceMapper mapper)
: CreateEntityCommandHandler<ServiceModel, CreateServiceDTO>(repo, mapper)
{
    public override ServiceModel AddAtributes(ServiceModel model, CreateServiceDTO request)
    {
        throw new NotImplementedException();
    }
}
