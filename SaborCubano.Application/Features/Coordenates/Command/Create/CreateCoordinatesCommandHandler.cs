using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Coordenate;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.Coordenates.Command.Create;

public class CreateCoordinatesCommandHandler(ICoordenatesRepository repo, CoordinatesMapper mapper)
: CreateEntityCommandHandler<CoordinatesModel, CreateCoordinatesDTO>(repo, mapper)
{

}
