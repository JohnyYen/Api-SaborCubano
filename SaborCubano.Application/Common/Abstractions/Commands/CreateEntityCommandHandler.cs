using System;
using Microsoft.EntityFrameworkCore.Metadata;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Commands;

public abstract class CreateEntityCommandHandler<TModel, TRequest>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper)
:IRequestHandler<TRequest, ResponseDto<TModel>>
where TModel : BaseEntity
where TRequest : CreateEntityCommandDto<TModel>
{
    private readonly IGenericRepository<TModel> _repo = repo;
    private readonly IMapper<TModel> _mapper = mapper;

    public async Task<ResponseDto<TModel>> Handle(TRequest request, CancellationToken cancellationToken)
    {
        var entity = _mapper.toModel(request);
        var model = await _repo.CreateAsync(entity);
        return _mapper.toDto(model);
    }
}
