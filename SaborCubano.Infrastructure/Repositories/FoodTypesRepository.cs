using System;
using api.Models;
using SaborCubano.Application.Interfaces;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class FoodTypesRepository : GenericRepository<FoodType>, IFoodTypesRepository
{
    public FoodTypesRepository(ApplicationDBContext context) : base(context)
    {
    }
}
