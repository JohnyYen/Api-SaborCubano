using System;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Domain;
using SaborCubano.Application.Interfaces.Mappers;

namespace SaborCubano.Application.Common.Abstractions.Commands;

public abstract class DeleteEntityCommandHandler<TModel, TRequest>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper)
:IRequestHandler<TRequest, ResponseDto<TModel>>
where TModel : BaseEntity
where TRequest : DeleteEntityCommandDto<TModel>
{
    protected readonly IGenericRepository<TModel> _repo = repo;
    protected readonly IMapper<TModel> _mapper = mapper;
    public async Task<ResponseDto<TModel>> Handle(TRequest request, CancellationToken ct)
    {
        var entity = await _repo.DeleteAsync(request.Id);

        return _mapper.toDto(entity!);
    }
}
