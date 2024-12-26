using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Bussines_Type;

namespace SaborCubano.API.Features.Bussines_Type.Update;

public class UpdateBussinesTypeEndpoint(IMediator mediator)
: UpdateEndpoint<UpdateBussinesTypeDTO, ResponseBussinesTypeDTO, BussinesType>
(mediator, "bussines_types/{id:int}")
{
    public override void AddConfiguration()
    {
        Description(x => x.WithTags("Bussines Types"));
    }
}
