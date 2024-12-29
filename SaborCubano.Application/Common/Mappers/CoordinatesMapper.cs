using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Coordenate;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;
using SaborCubano.Domain.Models;


namespace SaborCubano.Application.Common.Mappers;

public class CoordinatesMapper : IMapper<Coordinates>
{
    public ResponseDto<Coordinates> toDto(Coordinates model)
    {
        var response = new ResponseCoordenateDTO();
        response.Id_Res = model.Id_Res;
        response.Latitude = model.Latitude;
        response.Longitude = model.Longitude;

        return response;
    }

    public Coordinates toModel(CreateEntityCommandDto<Coordinates> dto)
    {
        var thisDTO = (CreateCoordinatesDTO)dto;
        var model = new Coordinates();

        model.Id_Res = thisDTO.Id_Res;
        model.Latitude = thisDTO.Latitude;
        model.Longitude = model.Longitude;

        return model;
    }

    public Coordinates toModel(UpdateEntityCommandDto<Coordinates> dto, BaseEntity model)
    {
        throw new NotImplementedException();
    }
}
