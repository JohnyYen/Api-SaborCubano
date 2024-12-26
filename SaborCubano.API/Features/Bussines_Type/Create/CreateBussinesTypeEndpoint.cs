using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Bussines_Type;

namespace SaborCubano.API.Features.Bussines_Type.Create;

public class CreateBussinesTypeEndpoint(IMediator mediator)
: CreateEndpoint<CreateBussinesTypeDTO, ResponseBussinesTypeDTO, BussinesType>(mediator, "bussines_types")
{
    public override void AddConfiguration()
    {
        Tags("Bussines Types");
    }
}
