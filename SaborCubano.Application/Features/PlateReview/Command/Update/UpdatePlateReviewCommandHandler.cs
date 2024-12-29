using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.PlateReview;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.PlateReview.Command.Update;

public class UpdatePlateReviewCommandHandler(IPlateReviewRepository repo, PlateReviewMapper mapper )
: UpdateEntityCommandHandler<PlateReviewModel, UpdatePlateReviewDTO>(repo, mapper)
{

}
