using System;
using SaborCubano.Application.Features.Service.Query.ToList;

namespace SaborCubano.API.Features.Service.ToList;

public class ToListServiceEndpoint : EndpointWithoutRequest<IEnumerable<api.Models.Service>>
{
    private readonly IMediator _mediator;

    public ToListServiceEndpoint(IMediator mediator){
        _mediator = mediator;
    }
    public override void Configure()
    {
        Get("api/restaurant/service");
        AllowAnonymous();
    }

    public override Task<IEnumerable<api.Models.Service>> ExecuteAsync(CancellationToken ct){
        var entities =  _mediator.Send(new ToListServiceQueryRequest());
       return entities;
    }
}
