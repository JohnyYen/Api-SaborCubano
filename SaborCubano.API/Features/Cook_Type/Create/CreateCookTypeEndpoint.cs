using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Cook_Type;

namespace SaborCubano.API.Features.Cook_Type.Create;

public class CreateCookTypeEndpoint(IMediator mediator)
: CreateEndpoint<CreateCookTypeDTO, ResponseCookTypeDTO, CookTypeModel>(mediator, "cook_type")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Cook Types"));
    }
}
