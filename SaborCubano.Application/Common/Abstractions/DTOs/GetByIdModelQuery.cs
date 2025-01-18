using System;
using Microsoft.EntityFrameworkCore.Metadata;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public abstract class GetByIdModelQuery<TModel> : IRequest<TModel>, IDto
where TModel : BaseEntity
{
    public int Id {get; set;}
}
