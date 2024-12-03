using System;
using api.Models;
using SaborCubano.Application.Features.BussinesType.Query.ToList;

namespace SaborCubano.API.Features.BussinesType.ToList;

public class ToListBussinesTypeEndpoint : EndpointWithoutRequest<IEnumerable<api.Models.BussinesType>>
{
      private readonly IMediator _mediator;
    public ToListBussinesTypeEndpoint(IMediator mediator){
        _mediator = mediator;
    }
    public override void Configure()
    {
        Get("api/restaurant/bussines-type");
        AllowAnonymous();
    }

    public override Task<IEnumerable<api.Models.BussinesType>> ExecuteAsync(CancellationToken ct){
        
       return _mediator.Send(new ToListBussinesTypeQuery());
    }
}
