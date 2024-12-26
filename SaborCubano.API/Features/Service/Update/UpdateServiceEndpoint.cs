using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Service;

namespace SaborCubano.API.Features.Service.Update;

public class UpdateServiceEndpoint(IMediator mediator)
: UpdateEndpoint<UpdateServiceDTO, ResponseServiceDTO, ServiceModel>(mediator, "service/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Services"));
    }
}
