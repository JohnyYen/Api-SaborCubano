using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Queries;

public abstract class ToListEntityQueryHandler<TModel>
(IGenericRepository<TModel> repo) :IRequestHandler<ToListEntityQueryDto<TModel>, IEnumerable<TModel>>
where TModel : BaseEntity
{
    protected readonly IGenericRepository<TModel> _repo = repo;

    public Task<IEnumerable<TModel>> Handle(ToListEntityQueryDto<TModel> request, CancellationToken cancellationToken)
    {
        var entities = _repo.GetAllAsync().ToList().AsEnumerable();
        return Task.FromResult(entities);
    }
}
