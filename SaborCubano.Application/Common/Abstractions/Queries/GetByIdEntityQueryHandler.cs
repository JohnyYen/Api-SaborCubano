using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Queries;

public class GetByIdEntityQueryHandler<TModel>
(IGenericRepository<TModel> repo): IRequestHandler<GetByIdEntityQuery<TModel>, TModel>
where TModel : BaseEntity
{

    protected readonly IGenericRepository<TModel> _repo = repo;
    public Task<TModel> Handle(GetByIdEntityQuery<TModel> request, CancellationToken cancellationToken)
    {
        var entity = _repo.GetByIdAsync(request.Id);

        return entity!;
    }
}
