using System;
using SaborCubano.Application.Common.DTOs.Coordenate;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.Coordenates.Query.GetByIdRestaurant;

public class GetByIdResCoordenatesQueryHandler(ICoordenatesRepository repo)
:IRequestHandler<GetByIdResCoordQuery, ResponseCoordenateDTO>
{
    private readonly ICoordenatesRepository _repo = repo;

    public async Task<ResponseCoordenateDTO> Handle(GetByIdResCoordQuery request, CancellationToken cancellationToken)
    {
        var coordenates = await _repo.GetByIdRestaurant(request.Id_Res);

        if (coordenates == null)
            throw new Exception("COORDENATE_NOT_FOUND");

        return new ResponseCoordenateDTO{
            Id_Res = coordenates.Id,
            Latitude = coordenates.Latitude,
            Longitude = coordenates.Longitude
        };
    }
}
