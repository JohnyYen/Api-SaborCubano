using System;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.DTOs;

public abstract class CreateEntityCommandDto<TModel> 
: IRequest<TModel>, IDto where TModel : BaseEntity
{

}
