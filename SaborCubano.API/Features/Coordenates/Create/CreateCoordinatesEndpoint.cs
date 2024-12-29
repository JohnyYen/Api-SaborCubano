using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Coordenate;
using SaborCubano.Domain.Models;

namespace SaborCubano.API.Features.Coordenates.Create;

public class CreateCoordinatesEndpoint(IMediator mediator)
: CreateEndpoint<CreateCoordinatesDTO, ResponseCoordenateDTO, Coordinates>
(mediator, "coordenates")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Locals Coordinates"));
    }
}
