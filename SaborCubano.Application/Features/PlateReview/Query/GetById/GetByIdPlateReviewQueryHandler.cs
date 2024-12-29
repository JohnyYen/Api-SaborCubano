using System;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.PlateReview.Query.GetById;

public class GetByIdPlateReviewQueryHandler(IPlateReviewRepository repo, PlateReviewMapper mapper)
: GetByIdEntityQueryHandler<PlateReviewModel, GetByIdPlateReviewQuery>(repo, mapper)
{

}
