using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class FoodTypeMapper : IMapper<FoodTypeModel>
{
    public ResponseDto<FoodTypeModel> toDto(FoodTypeModel model)
    {
        return new ResponseFoodTypeDTO {
            Id = model.Id,
            Name = model.Name
        };
    }

    public FoodTypeModel toModel(CreateEntityCommandDto<FoodTypeModel> dto)
    {
          var thisDTO = (CreateFoodTypeDTO)dto;
        return new FoodTypeModel {
            Name = thisDTO.Name
        };
    }

    public FoodTypeModel toModel(UpdateEntityCommandDto<FoodTypeModel> dto, BaseEntity model)
    {
        var thisModel = (FoodTypeModel)model;
        var thisDto = (UpdateFoodTypeDTO)dto;
        
        thisModel.Name = thisDto.Name;

        return thisModel;
    }
}
