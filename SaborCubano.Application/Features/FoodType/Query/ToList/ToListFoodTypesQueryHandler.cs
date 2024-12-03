using System;
using api.Models;
using SaborCubano.Application.Interfaces;

namespace SaborCubano.Application.Features.FoodType.Query.ToList;

public class ToListFoodTypesQueryHandler : IRequestHandler<ToListFoodTypeQuery, IEnumerable<api.Models.FoodType>>
{
    private readonly IFoodTypesRepository _repo;

    public ToListFoodTypesQueryHandler(IFoodTypesRepository repo){
        _repo = repo;
    }
    public Task<IEnumerable<api.Models.FoodType>> Handle(ToListFoodTypeQuery request, CancellationToken cancellationToken)
    {
        var entities = _repo.GetAllAsync().ToList();
        return Task.FromResult(entities.AsEnumerable());
    }
}
