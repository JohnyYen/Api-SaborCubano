using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Cook_Type;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class CookTypeMapper : IMapper<CookTypeModel>
{
    public ResponseDto<CookTypeModel> toDto(CookTypeModel model)
    {
        var response = new ResponseCookTypeDTO();

        response.Id = model.Id;
        response.Name = model.Name; 
        return  response;
    }

    public CookTypeModel toModel(CreateEntityCommandDto<CookTypeModel> dto)
    {
        var thisDTO = ((CreateCookTypeDTO)dto);

        var model = new CookTypeModel();
        model.Name = thisDTO.Name;

        return model;
    }

    public CookTypeModel toModel(UpdateEntityCommandDto<CookTypeModel> dto, BaseEntity model)
    {
        var thisDTO = ((UpdateCookTypeDTO)dto);

        var thisModel = (CookTypeModel) model;
        thisModel.Name = thisDTO.Name;

        return thisModel;
    }
}
