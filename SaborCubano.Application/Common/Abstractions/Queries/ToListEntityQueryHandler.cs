using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Queries;

public abstract class ToListEntityQueryHandler<TModel, TRequest>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper) 
:IRequestHandler<TRequest, IEnumerable<ResponseDto<TModel>>>
where TModel : BaseEntity
where TRequest : ToListEntityQueryDto<TModel>

{
    protected readonly IGenericRepository<TModel> _repo = repo;
    private readonly IMapper<TModel> _mapper = mapper;

    public Task<IEnumerable<ResponseDto<TModel>>> Handle(TRequest request, CancellationToken cancellationToken)
    {
        var entities =  _repo.GetAllAsync().Select(_mapper.toDto).ToList().AsEnumerable();
        return Task.FromResult(entities);
    }
}
