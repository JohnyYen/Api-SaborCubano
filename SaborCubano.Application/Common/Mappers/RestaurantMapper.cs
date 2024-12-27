using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class RestaurantMapper : IMapper<RestaurantModel>
{
    public ResponseDto<RestaurantModel> toDto(RestaurantModel model)
    {
        throw new NotImplementedException();
    }

    public RestaurantModel toModel(CreateEntityCommandDto<RestaurantModel> dto)
    {
        throw new NotImplementedException();
    }

    public RestaurantModel toModel(UpdateEntityCommandDto<RestaurantModel> dto, BaseEntity model)
    {
        throw new NotImplementedException();
    }
}
