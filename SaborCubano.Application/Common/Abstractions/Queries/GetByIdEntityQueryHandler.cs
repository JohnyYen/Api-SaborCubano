using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Queries;

public class GetByIdEntityQueryHandler<TModel>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper)
:IRequestHandler<GetByIdEntityQuery<TModel>, QueryDto<TModel>?>
where TModel : BaseEntity
{

    protected readonly IGenericRepository<TModel> _repo = repo;
    protected readonly IMapper<TModel> _mapper = mapper;
    public async Task<QueryDto<TModel>?> Handle(GetByIdEntityQuery<TModel> request, CancellationToken cancellationToken)
    {
        var entity = await _repo.GetByIdAsync(request.Id);

        return _mapper.toDto(entity);
    }
}
