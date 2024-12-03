using System;
using api.Models;
using SaborCubano.Application.Interfaces;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class BussinesRepository : GenericRepository<BussinesType>, IBussinesRepository
{
    public BussinesRepository(ApplicationDBContext context) : base(context)
    {
        
    }
}
