using System;
using api.Models;
using SaborCubano.Application.Interfaces.Repositories;
using SaborCubano.Infrastructure.Persistence;

namespace SaborCubano.Infrastructure.Repositories;

public class PlateReviewRepository(ApplicationDBContext context)
: GenericRepository<PlateReview>(context), IPlateReviewRepository
{

}
