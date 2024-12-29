using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.Abstractions.Queries;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.PlateReview.Query.ToList;

public class ToListPlateReviewQueryHandler(IPlateReviewRepository repo, PlateReviewMapper mapper)
: ToListEntityQueryHandler<PlateReviewModel, ToListPlateReviewQuery>(repo, mapper)
{

}
