using MediatR;
using SaborCubano.Application.DTOs.Restaurant;

namespace SaborCubano.Application.Features.Restaurant.Querys.ToList;

public record ToListRestaurantQuery() : IRequest<List<RestaurantDTO>>;
