using System;
using SaborCubano.Application.Interfaces.Repositories;
using SaborCubano.Domain.Models;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class CoordentatesRepository(ApplicationDBContext context)
: GenericRepository<Coordinates>(context), ICoordenatesRepository
{
    public async Task<Coordinates?> GetByIdRestaurant(int id_res)
    {
        var coord = await _context.GetDbSet<Coordinates>().FirstOrDefaultAsync( x => x.Id_Res == id_res);

        return coord;
    }
}
