using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Commands;

public abstract class CreateEntityCommandHandler<TModel>
(IGenericRepository<TModel> repo):IRequestHandler<CreateEntityCommandDto<TModel>, TModel>
where TModel : BaseEntity
{
    private readonly IGenericRepository<TModel> _repo = repo;

    public Task<TModel> Handle(CreateEntityCommandDto<TModel> request, CancellationToken cancellationToken)
    {
        return null;
    }
}
