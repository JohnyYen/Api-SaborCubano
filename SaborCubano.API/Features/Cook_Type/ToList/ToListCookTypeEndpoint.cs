using System;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Cook_Type;
using SaborCubano.Application.Features.Cook_Type.Query.ToList;

namespace SaborCubano.API.Features.Cook_Type.ToList;

public class ToListCookTypeEndpoint(IMediator mediator)
: ToListEndpoint<ResponseCookTypeDTO, ToListCookTypeQuery, CookTypeModel>(mediator, "cook_type")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Cook Types"));
    }
}
