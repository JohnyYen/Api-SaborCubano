using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Ingredient;
using SaborCubano.Application.Features.Ingredient.Query.ToList;

namespace SaborCubano.API.Features.Ingredient.ToList;

public class ToLisIngredientEndpoint(IMediator mediator)
: ToListEndpoint<ResponseIngredientDTO, ToListIngredientQuery, IngredientModel>
(mediator, "ingredient")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Ingredients"));
    }
}
