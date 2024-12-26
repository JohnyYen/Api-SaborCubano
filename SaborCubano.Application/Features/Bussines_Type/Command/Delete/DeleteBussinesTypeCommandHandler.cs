using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Bussines_Type;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Bussines_Type.Command.Delete;

public class DeleteBussinesTypeCommandHandler(IBussinesRepository repo, BussinesTypeMapper mapper)
: DeleteEntityCommandHandler<BussinesType, DeleteBussinesTypeDTO>(repo, mapper)
{

}
