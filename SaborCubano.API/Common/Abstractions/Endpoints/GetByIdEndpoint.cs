using System;
using SaborCubano.Application.Common.Abstractions;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.API.Common.Abstractions.Endpoints;

public abstract class GetByIdEndpoint<TRequest, TResponse, TMediator>
(IMediator mediator, string route) : Endpoint<TRequest, TResponse>
where TRequest : RequestGetByIdDTO, new()
where TResponse : IResponse, new()
where TMediator : CommandGetByIdDTO, new()
{
    protected readonly IMediator _mediator = mediator;

     public override void Configure()
    {
        Get($"api/{route}");
        AllowAnonymous();
    }

    public async override Task<TResponse> ExecuteAsync(TRequest request , CancellationToken ct){
        var command = CreateTMediatorInstance(request.Id);
        var entity = (await _mediator.Send(command))!;
       return (TResponse) entity;
    }

    private TMediator CreateTMediatorInstance(int requestId)
    {
        return (TMediator)Activator.CreateInstance(typeof(TMediator), requestId)!;
    }
}
