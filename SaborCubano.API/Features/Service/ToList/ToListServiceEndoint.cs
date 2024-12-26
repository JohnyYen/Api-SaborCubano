using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Service;
using SaborCubano.Application.Features.Service.Query;

namespace SaborCubano.API.Features.Service.ToList;

[Tags("Services")]
public class ToListServiceEndoint(IMediator mediator):
ToListEndpoint<ResponseServiceDTO, ToListServiceQuery, ServiceModel>(mediator, "service")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Services"));
    }
}
