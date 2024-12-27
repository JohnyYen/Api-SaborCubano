using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Cook_Type;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Cook_Type.Command.Update;

public class UpdateCookTypeCommandHandler(ICookTypeRepository repo, CookTypeMapper mapper)
: UpdateEntityCommandHandler<CookTypeModel, UpdateCookTypeDTO>(repo, mapper)
{

}
