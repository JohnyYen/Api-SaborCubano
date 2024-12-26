using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain;

namespace SaborCubano.API.Common.Abstractions.Endpoints;

public abstract class CreateEndpoint<TRequest, TResponse, TModel>
(IMediator mediator, string route) : Endpoint<TRequest, ResponseDto<TModel>>
where TRequest : CreateEntityCommandDto<TModel>,new()
where TResponse : ResponseDto<TModel>, new()
where TModel : BaseEntity
{
    protected readonly IMediator _mediator = mediator;
    
    public override void Configure()
    {
        Post($"api/{route}");
        AllowAnonymous();
        AddConfiguration();
    }

    public async override Task<ResponseDto<TModel>> ExecuteAsync(TRequest request, CancellationToken ct){
        var entity = (await _mediator.Send(request))!;
        Console.WriteLine(request.GetType());
        Console.WriteLine("AAAHHHHHH");
        return (TResponse) entity;
    }

    public abstract void AddConfiguration();
}
