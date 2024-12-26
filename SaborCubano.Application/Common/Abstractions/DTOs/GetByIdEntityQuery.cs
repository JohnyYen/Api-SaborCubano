using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public class GetByIdEntityQuery<TModel> : IRequest<ResponseDto<TModel>?>, IDto
 where TModel : BaseEntity
{
    public int Id {get; set;}
}
