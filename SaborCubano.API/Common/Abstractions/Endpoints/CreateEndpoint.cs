using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain;

namespace SaborCubano.API.Common.Abstractions.Endpoints;

public abstract class CreateEndpoint<TRequest, TResponse, TModel>
(IMediator mediator, string route) : Endpoint<TRequest, TResponse>
where TRequest : CreateEntityCommandDto<TModel>,new()
where TResponse : ResponseDto<TModel>, new()
where TModel : BaseEntity
{
    protected readonly IMediator _mediator = mediator;
    
    public override void Configure()
    {
        Post($"api/{route}");
        AllowAnonymous();
    }

    public async override Task<TResponse> ExecuteAsync(TRequest request, CancellationToken ct){
        var entity = (await _mediator.Send(request))!;
        return (TResponse) entity;
    }
}
