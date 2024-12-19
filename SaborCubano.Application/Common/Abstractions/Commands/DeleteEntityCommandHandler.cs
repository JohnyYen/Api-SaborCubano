using System;
using SaborCubano.Application.Interfaces;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Commands;

public abstract class DeleteEntityCommandHandler<TModel>
(IGenericRepository<TModel> repo): IRequestHandler<DeleteEntityCommand<TModel>, TModel>
where TModel : BaseEntity
{
    protected readonly IGenericRepository<TModel> _repo = repo;
    public Task<TModel> Handle(DeleteEntityCommand<TModel> request, CancellationToken ct)
    {
        var entity = _repo.DeleteAsync(request.Id);
        return entity!;
    }
}
