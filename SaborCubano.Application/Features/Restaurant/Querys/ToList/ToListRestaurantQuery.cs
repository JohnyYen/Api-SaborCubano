using MediatR;

namespace SaborCubano.Application.Features.Restaurant.Querys.ToList;

public record ToListRestaurantQuery(string name) : IRequest<IEnumerable<RestaurantDTO>>;
