using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Ingredient;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.Ingredient.Command.Update;

public class UpdateIngredientCommandHandler(IIngredientRepository repo, IngredientMapper mapper)
: UpdateEntityCommandHandler<IngredientModel, UpdateIngredientDTO>(repo, mapper)
{

}
