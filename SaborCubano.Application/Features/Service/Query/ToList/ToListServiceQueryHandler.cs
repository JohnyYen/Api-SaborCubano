using System;
using api.Models;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.Service.Query.ToList;

public class ToListServiceQueryHandler : IRequestHandler<ToListServiceQueryRequest, IEnumerable<api.Models.Service>>
{
    private readonly IServiceRepository _repo = null!;

    public ToListServiceQueryHandler(IServiceRepository repo){
        _repo = repo;
    }

    public Task<IEnumerable<api.Models.Service>> Handle(ToListServiceQueryRequest request, CancellationToken cancellationToken)
    {
       var entities = _repo.GetAllAsync().ToList().AsEnumerable();

       return Task.FromResult(entities);
    }
}
