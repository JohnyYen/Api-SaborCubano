using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Ingredient;

namespace SaborCubano.API.Features.Ingredient.Update;

public class UpdateIngredientEndpoint(IMediator mediator)
: UpdateEndpoint<UpdateIngredientDTO, ResponseIngredientDTO, IngredientModel>
(mediator, "ingredient/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Ingredients"));
    }
}
