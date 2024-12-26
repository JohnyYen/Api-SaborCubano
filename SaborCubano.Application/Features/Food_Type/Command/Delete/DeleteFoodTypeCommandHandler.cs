using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Food_Type.Command.Delete;

public class DeleteFoodTypeCommandHandler
(IFoodTypesRepository repo, FoodTypeMapper mapper)
: DeleteEntityCommandHandler<FoodTypeModel, DeleteFoodTypeDTO>(repo, mapper)
{

}
