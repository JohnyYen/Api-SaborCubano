using api.Models;

namespace SaborCubano.Application.Features.BussinesType.Query.ToList;

public record ToListBussinesTypeQuery : IRequest<IEnumerable<api.Models.BussinesType>>
{

}
