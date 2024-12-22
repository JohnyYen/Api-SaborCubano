using api.Models;
using SaborCubano.Application.DTOs.Restaurant;

namespace SaborCubano.Application.Features.Restaurants.Querys.GetById;

public record GetByIdRestaurantQuery(int id) : IRequest<RestaurantDTO>;
