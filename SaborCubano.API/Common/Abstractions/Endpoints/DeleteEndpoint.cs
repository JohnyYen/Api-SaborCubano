using System;
using SaborCubano.API.Features.Restaurant.GetByID;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain;

namespace SaborCubano.API.Common.Abstractions.Endpoints;

public abstract class DeleteEndpoint<TRequest, TResponse, TMediator, TModel>
(IMediator mediator, string route) : Endpoint<TRequest, TResponse>
where TRequest : GetByIdRequest,new()
where TResponse : ResponseDto<TModel>, new()
where TMediator : DeleteEntityCommandDto<TModel>, new()
where TModel : BaseEntity
{
    protected readonly IMediator _mediator = mediator;
    
    public override void Configure()
    {
        Delete($"api/{route}");
        AllowAnonymous();
    }

    public async override Task<TResponse> ExecuteAsync(TRequest request, CancellationToken ct){
        var entity = (await _mediator.Send(new TMediator()))!;
        return (TResponse) entity;
    }
}
