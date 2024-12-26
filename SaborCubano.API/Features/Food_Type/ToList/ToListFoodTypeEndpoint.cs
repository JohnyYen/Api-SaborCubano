using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Features.Food_Type.Query.ToList;

namespace SaborCubano.API.Features.Food_Type.ToList;

public class ToListFoodTypeEndpoint(IMediator mediator):
ToListEndpoint<ResponseFoodTypeDTO, ToListFoodTypeQuery, FoodTypeModel>(mediator, "food_type")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Food Types"));
    }
}
