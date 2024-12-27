using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Cook_Type;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Cook_Type.Command.Delete;

public class DeleteCookTypeCommandHandler(ICookTypeRepository repo, CookTypeMapper mapper)
: DeleteEntityCommandHandler<CookTypeModel, DeleteCookTypeDTO>(repo, mapper)
{

}
