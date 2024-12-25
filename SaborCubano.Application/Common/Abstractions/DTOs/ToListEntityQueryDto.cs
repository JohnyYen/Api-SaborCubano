using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public abstract class ToListEntityQueryDto<TModel>
: IRequest<IEnumerable<ResponseDto<TModel>>>, IDto
where TModel : BaseEntity 
{

}
