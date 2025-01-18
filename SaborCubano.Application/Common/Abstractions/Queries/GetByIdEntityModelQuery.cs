using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Queries;

public abstract class GetByIdEntityModelQueryHandler<TModel, TRequest>
(IGenericRepository<TModel> repo)
:IRequestHandler<TRequest, TModel?>
where TModel : BaseEntity
where TRequest : GetByIdModelQuery<TModel>
{

    protected readonly IGenericRepository<TModel> _repo = repo;
    public async Task<TModel?> Handle(TRequest request, CancellationToken cancellationToken)
    {
        var entity = await _repo.GetByIdAsync(request.Id);

        if( entity is null) return null;
        
        return entity;
    }
}
