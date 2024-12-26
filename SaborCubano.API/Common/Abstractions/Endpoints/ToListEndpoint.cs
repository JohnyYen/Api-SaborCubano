using System;
using SaborCubano.Application.Common.Abstractions;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain;

namespace SaborCubano.API.Common.Abstractions.Endpoints;

public abstract class ToListEndpoint<TResponse, TMediator, TModel>
(IMediator mediator, string route) : EndpointWithoutRequest<IEnumerable<TResponse>>
where TMediator : ToListEntityQueryDto<TModel>, new()
where TModel : BaseEntity
where TResponse : ResponseDto<TModel>
{
    protected readonly IMediator _mediator = mediator;
    
    public override void Configure()
    {
        Get($"api/{route}");
        AllowAnonymous();
        AddConfiguration();
    }

    public async override Task<IEnumerable<TResponse>> ExecuteAsync(CancellationToken ct){
        var entities = await _mediator.Send(new TMediator());
       return entities.AsEnumerable().Cast<TResponse>();
    }

    public abstract void AddConfiguration();
}
