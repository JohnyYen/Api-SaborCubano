using System;
using SaborCubano.API.Features.Restaurant.GetByID;
using SaborCubano.Application.Common.Abstractions;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.API.Common.Abstractions.Endpoints;

public abstract class DeleteEndpoint<TRequest, TResponse, TMediator>
(IMediator mediator, string route) : Endpoint<TRequest, TResponse>
where TRequest : GetByIdRequest,new()
where TResponse : IResponse, new()
where TMediator : class, new()
{
    protected readonly IMediator _mediator = mediator;
    
    public override void Configure()
    {
        Delete($"api/{route}");
        AllowAnonymous();
    }

    public async override Task<TResponse> ExecuteAsync(TRequest request, CancellationToken ct){
        var entities = (await _mediator.Send(new TMediator()))!;
        return (TResponse) entities;
    }
}
