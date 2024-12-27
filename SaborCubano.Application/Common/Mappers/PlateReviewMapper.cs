using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class PlateReviewMapper : IMapper<PlateReview>
{
    public ResponseDto<PlateReview> toDto(PlateReview model)
    {
        throw new NotImplementedException();
    }

    public PlateReview toModel(CreateEntityCommandDto<PlateReview> dto)
    {
        throw new NotImplementedException();
    }

    public PlateReview toModel(UpdateEntityCommandDto<PlateReview> dto, BaseEntity model)
    {
        throw new NotImplementedException();
    }
}
