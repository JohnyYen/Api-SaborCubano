using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Common.DTOs.Restaurant;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class RestaurantMapper : IMapper<RestaurantModel>
{
    public ResponseDto<RestaurantModel> toDto(RestaurantModel model)
    {
       return new ResponseRestaurantDTO{
        Name = model.Name
       };
    }

    public RestaurantModel toModel(CreateEntityCommandDto<RestaurantModel> dto)
    {
        var thisDTO = (CreateRestaurantDTO)dto;
        return new RestaurantModel {
            Name = thisDTO.Name
        };
    }

    public RestaurantModel toModel(UpdateEntityCommandDto<RestaurantModel> dto, BaseEntity model)
    {
        var thisModel = (RestaurantModel)model;
        var thisDto = (UpdateRestaurantDTO)dto;
        
        thisModel.Name = thisDto.Name;

        return thisModel;
    }
}
