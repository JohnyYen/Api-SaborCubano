using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Service;

namespace SaborCubano.API.Features.Service.Create;

public class CreateServiceEndpoint(IMediator mediator)
:CreateEndpoint<CreateServiceDTO, ResponseServiceDTO, ServiceModel>(mediator, "service")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Services"));
    }
}
