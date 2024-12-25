using System;
using Microsoft.EntityFrameworkCore.Metadata;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain;

namespace SaborCubano.Application.Interfaces.Mappers;

public interface IMapper<TModel> where TModel : BaseEntity
{
    TModel toModel(CreateEntityCommandDto<TModel> dto);
    TModel toModel(UpdateEntityCommandDto<TModel> dto);
    ResponseDto<TModel> toDto (TModel model);
}
