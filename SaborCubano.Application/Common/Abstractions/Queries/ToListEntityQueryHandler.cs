using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Queries;

public abstract class ToListEntityQueryHandler<TModel>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper) 
:IRequestHandler<ToListEntityQueryDto<TModel>, IEnumerable<QueryDto<TModel>>>
where TModel : BaseEntity
{
    protected readonly IGenericRepository<TModel> _repo = repo;
    private readonly IMapper<TModel> _mapper = mapper;

    public Task<IEnumerable<QueryDto<TModel>>> Handle(ToListEntityQueryDto<TModel> request, CancellationToken cancellationToken)
    {
        var entities = _repo.GetAllAsync().ToList().AsEnumerable().Select(x => _mapper.toDto(x));
        return Task.FromResult(entities);
    }
}
