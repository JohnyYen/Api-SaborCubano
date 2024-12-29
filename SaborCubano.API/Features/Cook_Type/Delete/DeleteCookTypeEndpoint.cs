using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Cook_Type;

namespace SaborCubano.API.Features.Cook_Type.Delete;

public class DeleteCookTypeEndpoint(IMediator mediator)
: DeleteEndpoint<DeleteCookTypeRequest, ResponseCookTypeDTO, DeleteCookTypeDTO,CookTypeModel>(mediator, "cook_type/{id:int}")
{
     public override void AddConfiguration()
    {
        Description(x => x.WithTags("Cook Types"));
    }
}
