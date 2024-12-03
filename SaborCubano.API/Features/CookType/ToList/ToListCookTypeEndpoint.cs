using System;
using api.Models;
using SaborCubano.Application.Features.CookType.Query.ToList;

namespace SaborCubano.API.Features.CookType.ToList;

public class ToListCookTypeEndpoint : EndpointWithoutRequest<IEnumerable<api.Models.CookType>>
{
    private readonly IMediator _mediator;
    public ToListCookTypeEndpoint(IMediator mediator){
        _mediator = mediator;
    }
    
    public override void Configure()
    {
        Get("api/restaurant/cook-type");
        AllowAnonymous();
    }

    public override Task<IEnumerable<api.Models.CookType>> ExecuteAsync(CancellationToken ct){
        var entities = _mediator.Send(new ToListCookTypeQuery());
       return entities;
    }
}
