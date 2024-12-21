using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public class UpdateEntityCommandDto<TModel>:IRequest<TModel>, IDto
where TModel : BaseEntity
{

}
