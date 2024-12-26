using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Bussines_Type;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class BussinesTypeMapper : IMapper<BussinesType>
{
    public ResponseDto<BussinesType> toDto(BussinesType model)
    {
        return new ResponseBussinesTypeDTO {
            Id = model.Id,
            Name = model.Name
        };
    }

    public BussinesType toModel(CreateEntityCommandDto<BussinesType> dto)
    {
        var thisDTO = (CreateBussinesTypeDTO)dto;
        return new BussinesType {
            Name = thisDTO.Name
        };
    }

    public BussinesType toModel(UpdateEntityCommandDto<BussinesType> dto, BaseEntity model)
    {
        var thisModel = (BussinesType)model;
        var thisDto = (UpdateBussinesTypeDTO)dto;
        
        thisModel.Name = thisDto.Name;

        return thisModel;
    }
}
