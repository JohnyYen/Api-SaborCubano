using System;
using Microsoft.EntityFrameworkCore.Metadata;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public class UpdateEntityCommandDto<TModel>:IRequest<ResponseDto<TModel>?>, IDto
where TModel : BaseEntity
{
    public int Id {get; set;}
}
