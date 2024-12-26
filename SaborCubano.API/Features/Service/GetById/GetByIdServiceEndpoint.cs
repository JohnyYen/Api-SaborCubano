using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Service;
using SaborCubano.Application.Features.Service.Query.GetById;

namespace SaborCubano.API.Features.Service.GetById;


public class GetByIdServiceEndpoint(IMediator mediator)
: GetByIdEndpoint<GetByIdServiceRequest, ResponseServiceDTO, ServiceModel, GetByIdServiceQuery>(mediator, "service/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Services"));
    }
}
