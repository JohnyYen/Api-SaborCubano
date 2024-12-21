using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain;


public abstract class DeleteEntityCommandDto<TModel>
: IRequest<TModel>, IDto where TModel : BaseEntity
{
    public int Id {get;}
}
