using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Bussines_Type;
using SaborCubano.Application.Features.Bussines_Type.Query.ToList;

namespace SaborCubano.API.Features.Bussines_Type.ToList;

public class ToListBussinesTypeEndpoint(IMediator mediator)
: ToListEndpoint<ResponseBussinesTypeDTO, ToListBussinesTypeQuery, BussinesType>(mediator, "bussines_types")
{
    public override void AddConfiguration()
    {
        Tags("Bussines Types");
    }
}
