using System;
using SaborCubano.Domain.Models;

namespace SaborCubano.Application.Interfaces.Repositories;

public interface ICoordenatesRepository : IGenericRepository<Coordinates>
{
    public Task<Coordinates?> GetByIdRestaurant (int id_res);
}
