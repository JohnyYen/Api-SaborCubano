using System;
using Microsoft.EntityFrameworkCore.Metadata;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Commands;

public abstract class CreateEntityCommandHandler<TModel>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper)
:IRequestHandler<CreateEntityCommandDto<TModel>, QueryDto<TModel>>
where TModel : BaseEntity
{
    private readonly IGenericRepository<TModel> _repo = repo;
    private readonly IMapper<TModel> _mapper = mapper;

    public async Task<QueryDto<TModel>> Handle(CreateEntityCommandDto<TModel> request, CancellationToken cancellationToken)
    {
        var entity = _mapper.toModel(request);
        var model = await _repo.CreateAsync(entity);
        return _mapper.toDto(model);
    }
}
