using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Bussines_Type;
using SaborCubano.Application.Features.Bussines_Type.Query.GetById;

namespace SaborCubano.API.Features.Bussines_Type.GetById;

public class GetByIdBussinesTypeEndpoint(IMediator mediator)
: GetByIdEndpoint<GetByIdBussinesTypeRequest, ResponseBussinesTypeDTO, BussinesType, GetByIdBussinesTypeQuery>
(mediator, "bussines_types/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Bussines Types"));
    }
}
