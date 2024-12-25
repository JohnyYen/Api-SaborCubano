using System;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain;
using SaborCubano.Application.Interfaces.Mappers;

namespace SaborCubano.Application.Common.Abstractions.Commands;

public abstract class DeleteEntityCommandHandler<TModel>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper)
:IRequestHandler<DeleteEntityCommandDto<TModel>, QueryDto<TModel>>
where TModel : BaseEntity
{
    protected readonly IGenericRepository<TModel> _repo = repo;
    protected readonly IMapper<TModel> _mapper = mapper;
    public async Task<QueryDto<TModel>> Handle(DeleteEntityCommandDto<TModel> request, CancellationToken ct)
    {
        var entity = await _repo.DeleteAsync(request.Id);
        return _mapper.toDto(entity!);
    }
}
