using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Food_Type.Command.Create;

public class CreateFoodTypeCommandHandler
(IFoodTypesRepository repo, FoodTypeMapper mapper)
: CreateEntityCommandHandler<FoodTypeModel, CreateFoodTypeDTO>(repo, mapper)
{

    public override FoodTypeModel AddAtributes(FoodTypeModel model, CreateFoodTypeDTO request)
    {
        return model;
    }
}