using System;

namespace SaborCubano.API.Common.Abstractions.Endpoints;

public abstract class ToListEndpoint<TResponse, TMediator>
(IMediator mediator, string route) : EndpointWithoutRequest<IEnumerable<TResponse>>
where TMediator : class, new()
where TResponse : class, new()
{
    protected readonly IMediator _mediator = mediator;
    
    public override void Configure()
    {
        Get($"api/{route}");
        AllowAnonymous();
    }

    public async override Task<IEnumerable<TResponse>> ExecuteAsync(CancellationToken ct){
        var entities = (await _mediator.Send(new TMediator()))!;
       return (IEnumerable<TResponse>) entities;
    }
}
