using System;
using api.Models;

namespace SaborCubano.Domain.Interfaces;

public interface ICookTypeRepository
{
    public Task<List<CookType>> GetAllAsync();
}
