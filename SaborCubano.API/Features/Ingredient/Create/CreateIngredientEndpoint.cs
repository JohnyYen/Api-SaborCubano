using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Ingredient;

namespace SaborCubano.API.Features.Ingredient.Delete;

public class CreateIngredientEndpoint(IMediator mediator)
: CreateEndpoint<CreateIngredientDTO, ResponseIngredientDTO, IngredientModel>
(mediator, "ingredient")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Ingredients"));
    }
}
