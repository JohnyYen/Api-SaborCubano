using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.Ingredient.Query.GetByIdModel;

public class GetByIdIngredientQueryHandler(IIngredientRepository repo)
: GetByIdEntityModelQueryHandler<IngredientModel, GetByIdIngredientQuery>(repo)
{

}
