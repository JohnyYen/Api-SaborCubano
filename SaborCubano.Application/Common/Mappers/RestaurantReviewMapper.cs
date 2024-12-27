using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class RestaurantReviewMapper : IMapper<RestaurantReviewModel>
{
    public ResponseDto<RestaurantReviewModel> toDto(RestaurantReviewModel model)
    {
        throw new NotImplementedException();
    }

    public RestaurantReviewModel toModel(CreateEntityCommandDto<RestaurantReviewModel> dto)
    {
        throw new NotImplementedException();
    }

    public RestaurantReviewModel toModel(UpdateEntityCommandDto<RestaurantReviewModel> dto, BaseEntity model)
    {
        throw new NotImplementedException();
    }
}
