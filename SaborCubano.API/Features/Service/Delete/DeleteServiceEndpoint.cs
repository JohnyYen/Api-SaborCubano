using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Service;

namespace SaborCubano.API.Features.Service.Delete;

public class DeleteServiceEndpoint(IMediator mediator)
:DeleteEndpoint<DeleteServiceRequest, ResponseServiceDTO, DeleteServiceDTO, ServiceModel>(mediator, "service/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Services"));
    }
}
