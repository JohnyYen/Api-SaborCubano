using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class CookTypeMapper : IMapper<CookTypeModel>
{
    public ResponseDto<CookTypeModel> toDto(CookTypeModel model)
    {
        throw new NotImplementedException();
    }

    public CookTypeModel toModel(CreateEntityCommandDto<CookTypeModel> dto)
    {
        throw new NotImplementedException();
    }

    public CookTypeModel toModel(UpdateEntityCommandDto<CookTypeModel> dto, BaseEntity model)
    {
        throw new NotImplementedException();
    }
}
