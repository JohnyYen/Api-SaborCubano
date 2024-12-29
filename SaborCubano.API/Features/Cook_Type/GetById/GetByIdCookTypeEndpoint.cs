using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Cook_Type;
using SaborCubano.Application.Features.Cook_Type.Query.GetById;

namespace SaborCubano.API.Features.Cook_Type.GetById;

public class GetByIdCookTypeEndpoint(IMediator mediator)
: GetByIdEndpoint<GetByIdCookTypeRequest, ResponseCookTypeDTO, CookTypeModel, GetByIdCookTypeQuery>
(mediator, "cook_type/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Cook Types"));
    }
}
