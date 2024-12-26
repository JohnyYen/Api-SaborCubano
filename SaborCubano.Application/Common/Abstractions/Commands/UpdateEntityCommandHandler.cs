using System;
using Microsoft.EntityFrameworkCore.Metadata;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Commands;

public class UpdateEntityCommandHandler<TModel, TRequest>
(IGenericRepository<TModel> repo, IMapper<TModel> mapper)
:IRequestHandler<TRequest, ResponseDto<TModel>?>
where TModel : BaseEntity
where TRequest : UpdateEntityCommandDto<TModel>
{
    private readonly IGenericRepository<TModel> _repo = repo;
    private readonly IMapper<TModel> _mapper = mapper;
    public async Task<ResponseDto<TModel>?> Handle(TRequest request, CancellationToken cancellationToken)
    {
        var model = await _repo.GetByIdAsync(request.Id);

        if(model is null)
            throw new Exception("ENTITY_NOT_FOUND");

        var entity = _mapper.toModel(request, model);
        await _repo.UpdateAsync(entity);
    
        return _mapper.toDto(entity);
    }
}
