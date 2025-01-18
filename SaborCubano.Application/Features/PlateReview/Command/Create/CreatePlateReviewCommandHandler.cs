using System;
using SaborCubano.Application.Common.Abstractions.Commands;
using SaborCubano.Application.Common.DTOs.PlateReview;
using SaborCubano.Application.Common.Mappers;
using SaborCubano.Application.Interfaces.Repositories;

namespace SaborCubano.Application.Features.PlateReview.Command.Create;

public class CreatePlateReviewCommandHandler(IPlateReviewRepository repo, PlateReviewMapper mapper)
: CreateEntityCommandHandler<PlateReviewModel, CreatePlateReviewDTO>(repo, mapper)
{

    public override PlateReviewModel AddAtributes(PlateReviewModel model, CreatePlateReviewDTO request)
    {
        throw new NotImplementedException();
    }
}
