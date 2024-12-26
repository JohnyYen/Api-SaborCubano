using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Features.Food_Type.Query.GetById;

namespace SaborCubano.API.Features.Food_Type.GetById;

public class GetByIdFoodTypeEndpoint(IMediator mediator)
: GetByIdEndpoint<GetByIdFoodTypeRequest, ResponseFoodTypeDTO, FoodTypeModel, GetByIdFoodTypeQuery>
(mediator, "food_type/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Food Types"));
    }
}
