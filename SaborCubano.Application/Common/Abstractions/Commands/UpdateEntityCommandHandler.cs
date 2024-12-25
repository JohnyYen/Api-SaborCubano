using System;
using Microsoft.EntityFrameworkCore.Metadata;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Commands;

public class UpdateEntityCommandHandler<TModel>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper)
:IRequestHandler<UpdateEntityCommandDto<TModel>, ResponseDto<TModel>?>
where TModel : BaseEntity, IModel
{
    private readonly IGenericRepository<TModel> _repo = repo;
    private readonly IMapper<TModel> _mapper = mapper;
    public async Task<ResponseDto<TModel>?> Handle(UpdateEntityCommandDto<TModel> request, CancellationToken cancellationToken)
    {
        var entity = _mapper.toModel(request);
        var model = await _repo.UpdateAsync(entity) ?? null;
        
        return _mapper.toDto(model!);
    }
}
