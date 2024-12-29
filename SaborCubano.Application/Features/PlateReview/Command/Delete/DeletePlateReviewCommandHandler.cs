using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.PlateReview;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.PlateReview.Command.Delete;

public class DeletePlateReviewCommandHandler(IPlateReviewRepository repo, PlateReviewMapper mapper)
: DeleteEntityCommandHandler<PlateReviewModel, DeletePlateReviewDTO>(repo, mapper)
{

}
