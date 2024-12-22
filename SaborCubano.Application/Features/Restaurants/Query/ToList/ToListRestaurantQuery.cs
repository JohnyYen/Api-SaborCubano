using api.Models;
using MediatR;
using SaborCubano.Application.DTOs.Restaurant;

namespace SaborCubano.Application.Features.Restaurants.Querys.ToList;

public record ToListRestaurantQuery() : IRequest<IEnumerable<RestaurantDTO>>;
