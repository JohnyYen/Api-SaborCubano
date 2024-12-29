using System;
using SaborCubano.Application.Common.DTOs.Coordenate;

namespace SaborCubano.Application.Features.Coordenates.Query.GetByIdRestaurant;

public class GetByIdResCoordQuery : IRequest<ResponseCoordenateDTO>
{
    public int Id_Res {get; set;}
}
