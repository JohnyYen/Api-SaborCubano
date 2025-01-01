using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Ingredient;
using SaborCubano.Application.Features.Ingredient.Query.GetById;

namespace SaborCubano.API.Features.Ingredient.GetById;

public class GetByIdIngredientEndpoint(IMediator mediator)
: GetByIdEndpoint<GetByIdIngredientRequest, ResponseIngredientDTO, IngredientModel, GetByIdIngredientQuery>
(mediator, "ingredient/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Ingredients"));
    }
}
