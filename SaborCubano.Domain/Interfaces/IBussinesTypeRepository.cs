using System;
using api.Models;

namespace SaborCubano.Domain.Interfaces;

public interface IBussinesTypeRepository
{
    public Task<List<BussinesType>> GetAllAsync();
}
