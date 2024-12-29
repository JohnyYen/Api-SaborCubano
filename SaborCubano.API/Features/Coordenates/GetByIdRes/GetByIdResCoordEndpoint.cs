using System;
using Microsoft.AspNetCore.Http.HttpResults;
using SaborCubano.Application.Common.DTOs.Coordenate;
using SaborCubano.Application.Features.Coordenates.Query.GetByIdRestaurant;

namespace SaborCubano.API.Features.Coordenates.GetByIdRes;

public class GetByIdResCoordEndpoint(IMediator mediator)
: Endpoint<GetByIdResCoordRequest, ResponseCoordenateDTO>
{
    private readonly IMediator _mediator = mediator;

    public override void Configure()
    {
        Get("api/coordenate/{id:int}");
        Description(x => x.WithTags("Locals Coordinates"));
        AllowAnonymous();
    }

    public async override Task<ResponseCoordenateDTO> ExecuteAsync(GetByIdResCoordRequest request, CancellationToken ct){
       
       if(request is null)
            throw new Exception("REQUEST_NOT_FOUND");

       var response = await _mediator.Send(request: new GetByIdResCoordQuery{});

        return response;
    }
}
