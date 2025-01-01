using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Ingredient;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.Ingredient.Command.Delete;

public class DeleteIngredientCommandHandler(IIngredientRepository repo, IngredientMapper mapper)
: DeleteEntityCommandHandler<IngredientModel, DeleteIngredientDTO>(repo, mapper)
{

}
