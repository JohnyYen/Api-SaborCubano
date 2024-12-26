using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Bussines_Type;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Bussines_Type.Command.Update;

public class UpdateBussinesTypeCommandHandler(IBussinesRepository repo, BussinesTypeMapper mapper)
: UpdateEntityCommandHandler<BussinesType, UpdateBussinesTypeDTO>(repo, mapper)
{

}
