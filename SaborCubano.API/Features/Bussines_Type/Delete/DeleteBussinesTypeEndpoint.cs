using System;
using api.Models;
using SaborCubano.API.Common.Abstractions.Endpoints;
using SaborCubano.Application.Common.DTOs.Bussines_Type;

namespace SaborCubano.API.Features.Bussines_Type.Delete;

public class DeleteBussinesTypeEndpoint(IMediator mediator)
: DeleteEndpoint<DeleteBussinesTypeRequest, ResponseBussinesTypeDTO,DeleteBussinesTypeDTO, BussinesType>
(mediator, "bussines_types/{id:int}")
{
    public override void AddConfiguration()
    {
        Tags("Bussines_Types");
    }
}
