using System;
using api.Models;
using SaborCubano.Application.Interfaces;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class CookTypeRepository : GenericRepository<CookType>, ICookTypeRepository
{
    public CookTypeRepository(ApplicationDBContext context) : base(context)
    {
    }
}
