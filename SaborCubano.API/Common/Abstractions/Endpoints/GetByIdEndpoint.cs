using System;
using SaborCubano.API.Features.Restaurant.GetByID;
using SaborCubano.Application.Common.Abstractions;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain;

namespace SaborCubano.API.Common.Abstractions.Endpoints;

public abstract class GetByIdEndpoint<TRequest, TResponse, TModel, TMediator>
(IMediator mediator, string route) : Endpoint<TRequest, TResponse>
where TRequest : GetByIdRequest, new()
where TResponse : ResponseDto<TModel>, new()
where TModel : BaseEntity
where TMediator : GetByIdEntityQuery<TModel>, new()
{
    protected readonly IMediator _mediator = mediator;

     public override void Configure()
    {
        Get($"api/{route}");
        AllowAnonymous();
        AddConfiguration();
    }

    public async override Task<TResponse> ExecuteAsync(TRequest request , CancellationToken ct){
        var entity = (await _mediator.Send(new TMediator{Id = request.Id}))!;
       return (TResponse) entity;
    }

    public abstract void AddConfiguration();
}
