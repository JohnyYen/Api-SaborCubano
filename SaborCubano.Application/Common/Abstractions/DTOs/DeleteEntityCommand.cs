using System;
using SaborCubano.Domain;


public abstract class DeleteEntityCommand<TModel>
: IRequest<TModel> where TModel : BaseEntity
{
    public int Id {get;}
    public DeleteEntityCommand(int id) { Id = id; }
}
