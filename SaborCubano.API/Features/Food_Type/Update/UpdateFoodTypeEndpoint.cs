using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Food_Type;

namespace SaborCubano.API.Features.Food_Type.Update;

public class UpdateFoodTypeEndpoint(IMediator mediator)
: UpdateEndpoint<UpdateFoodTypeDTO, ResponseFoodTypeDTO, FoodTypeModel>(mediator, "food_type/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Food Types"));
    }
}