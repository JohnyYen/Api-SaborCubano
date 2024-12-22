using System;
using api.Models;
using SaborCubano.Application.Interfaces;
namespace SaborCubano.Application.Features.CookType.Query.ToList;

public class ToListCookTypeQueryHandler : IRequestHandler<ToListCookTypeQuery, IEnumerable<api.Models.CookType>>
{
    private readonly ICookTypeRepository _repo;

    public ToListCookTypeQueryHandler(ICookTypeRepository repo){
        _repo = repo;
    }

    public Task<IEnumerable<api.Models.CookType>> Handle(ToListCookTypeQuery request, CancellationToken cancellationToken)
    {
       var entities = _repo.GetAllAsync().ToList();

       return Task.FromResult(entities.AsEnumerable());
    }
}
