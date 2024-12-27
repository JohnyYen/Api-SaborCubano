using System;
using api.Models;
using SaborCubano.Application.Interfaces.Repositories;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class RestaurantReviewRepository(ApplicationDBContext context)
: GenericRepository<RestaurantReview>(context), IRestaurantReviewRepository
{

}
