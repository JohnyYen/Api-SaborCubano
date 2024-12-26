using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Food_Type;

namespace SaborCubano.API.Features.Food_Type.Create;

public class CreateFoodTypeEndpoint(IMediator mediator)
:CreateEndpoint<CreateFoodTypeDTO, ResponseFoodTypeDTO, FoodTypeModel>(mediator, "food_type")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Food Types"));
    }
}
