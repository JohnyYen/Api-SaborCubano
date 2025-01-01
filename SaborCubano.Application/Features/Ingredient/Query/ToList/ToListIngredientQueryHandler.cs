using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.Ingredient.Query.ToList;

public class ToListIngredientQueryHandler(IIngredientRepository repo, IngredientMapper mapper)
: ToListEntityQueryHandler<IngredientModel, ToListIngredientQuery>(repo, mapper)
{

}
