using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public class GetByIdEntityQuery<TModel> : IRequest<QueryDto<TModel>?>, IDto
 where TModel : BaseEntity
{
    public int Id {get;}
}
