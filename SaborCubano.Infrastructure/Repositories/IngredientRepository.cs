using System;
using api.Models;
using SaborCubano.Application.Interfaces.Repositories;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class IngredientRepository(ApplicationDBContext context)
: GenericRepository<Ingredient>(context), IIngredientRepository
{

}
