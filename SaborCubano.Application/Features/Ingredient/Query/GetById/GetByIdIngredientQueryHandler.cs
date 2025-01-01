using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.Ingredient.Query.GetById;

public class GetByIdIngredientQueryHandler(IIngredientRepository repo, IngredientMapper mapper)
: GetByIdEntityQueryHandler<IngredientModel, GetByIdIngredientQuery>(repo, mapper) 
{

}
