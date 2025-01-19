using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.Cook_Type;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Cook_Type.Command.Create;

public class CreateCookTypeCommandHandler(ICookTypeRepository repo, CookTypeMapper mapper)
: CreateEntityCommandHandler<CookTypeModel, CreateCookTypeDTO>(repo, mapper)
{
    public override CookTypeModel AddAtributes(CookTypeModel model, CreateCookTypeDTO request)
    {
       return model;
    }
}
