using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Queries;

public class GetByIdEntityQueryHandler<TModel, TRequest>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper)
:IRequestHandler<TRequest, ResponseDto<TModel>?>
where TModel : BaseEntity
where TRequest : GetByIdEntityQuery<TModel>
{

    protected readonly IGenericRepository<TModel> _repo = repo;
    protected readonly IMapper<TModel> _mapper = mapper;
    public async Task<ResponseDto<TModel>?> Handle(TRequest request, CancellationToken cancellationToken)
    {
        var entity = await _repo.GetByIdAsync(request.Id);

        if( entity is null) return null;
        
        return _mapper.toDto(entity);
    }
}
