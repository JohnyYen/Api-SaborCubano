using System;

namespace SaborCubano.API.Features.Restaurant.ToList;

public class ToListEndpoint : Endpoint<ToListResponse>
{

    private readonly IMediator _mediator;
    public ToListEndpoint(IMediator mediator){
        _mediator = mediator;
    }
    public override void Configure()
    {
        Get("api/restaurant");
        AllowAnonymous();
    }

    public override Task<ToListResponse> ExecuteAsync(CancellationToken ct){
        
       // return Task Task.FromResult()
    }
}
