using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Ingredient;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.Ingredient.Command.Create;

public class CreateIngredientCommandHandler(IIngredientRepository repo, IngredientMapper mapper)
: CreateEntityCommandHandler<IngredientModel, CreateIngredientDTO>(repo, mapper)
{

}
