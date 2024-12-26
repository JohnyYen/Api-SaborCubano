using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Food_Type;

namespace SaborCubano.API.Features.Food_Type.Delete;

public class DeleteFoodTypeEndpoint (IMediator mediator)
:DeleteEndpoint<DeleteFoodTypeRequest, ResponseFoodTypeDTO, DeleteFoodTypeDTO, FoodTypeModel>
(mediator, "food_type/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Food Types"));
    }
}
