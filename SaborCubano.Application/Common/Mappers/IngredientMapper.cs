using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Ingredient;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class IngredientMapper : IMapper<IngredientModel>
{
    public ResponseDto<IngredientModel> toDto(IngredientModel model)
    {
        return new ResponseIngredientDTO{
            Id = model.Id,
            Name = model.Name
        };
    }

    public IngredientModel toModel(CreateEntityCommandDto<IngredientModel> dto)
    {
        var thisDTO = (CreateIngredientDTO)dto;
        return new IngredientModel{
            Name = thisDTO.Name
        };
    }

    public IngredientModel toModel(UpdateEntityCommandDto<IngredientModel> dto, BaseEntity model)
    {
        var thisDTO = (UpdateIngredientDTO)dto;
        var thisModel = (IngredientModel)model;

        thisModel.Name = thisDTO.Name;
        return thisModel;
    }
}
