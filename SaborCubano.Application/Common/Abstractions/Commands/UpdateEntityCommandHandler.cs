using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Abstractions.Commands;

public class UpdateEntityCommandHandler<TModel>
(IGenericRepository<TModel> repo):IRequestHandler<UpdateEntityCommandDto<TModel>, TModel>
where TModel : BaseEntity
{
    private readonly IGenericRepository<TModel> _repo = repo;

    public Task<TModel> Handle(UpdateEntityCommandDto<TModel> request, CancellationToken cancellationToken)
    {
        throw null;
    }
}
