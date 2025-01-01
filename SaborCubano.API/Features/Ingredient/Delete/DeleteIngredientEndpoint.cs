using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Ingredient;

namespace SaborCubano.API.Features.Ingredient.Delete;

public class DeleteIngredientEndpoint(IMediator mediator)
: DeleteEndpoint<DeleteIngredientRequest, ResponseIngredientDTO, DeleteIngredientDTO , IngredientModel>
(mediator, "ingredient/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Ingredients"));
    }
}
