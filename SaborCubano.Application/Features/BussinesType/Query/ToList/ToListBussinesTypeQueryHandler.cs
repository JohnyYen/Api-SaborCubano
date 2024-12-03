using System;
using api.Models;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.BussinesType.Query.ToList;

public class ToListBussinesTypeQueryHandler : IRequestHandler<ToListBussinesTypeQuery, IEnumerable<api.Models.BussinesType>>
{
    public readonly IBussinesRepository _repo = null!;

    public ToListBussinesTypeQueryHandler(IBussinesRepository repo){
        _repo = repo;
    }

    public Task<IEnumerable<api.Models.BussinesType>> Handle(ToListBussinesTypeQuery request, CancellationToken cancellationToken)
    {
        var entities = _repo.GetAllAsync().ToList();

        return Task.FromResult(_repo.GetAllAsync().ToList().AsEnumerable());
    }
}
