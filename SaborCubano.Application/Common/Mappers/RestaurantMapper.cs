using System;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Bussines_Type;
using SaborCubano.Application.Common.DTOs.City;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Common.DTOs.Restaurant;
using SaborCubano.Application.Common.DTOs.Service;
using SaborCubano.Application.Interfaces.Mappers;
using SaborCubano.Domain;

namespace SaborCubano.Application.Common.Mappers;

public class RestaurantMapper : IMapper<RestaurantModel>
{
    public ResponseDto<RestaurantModel> toDto(RestaurantModel model)
    {
        var response = new ResponseRestaurantDTO{
            Id = model.Id,
            Name = model.Name,
            Direction = model.Direction,

            BussinesTypes = model.BussinesTypes.Select(b => new ResponseBussinesTypeDTO {
                Id = b.Id,
                Name = b.Name
            }),
            FoodTypes = model.FoodTypes.Select(f => new ResponseFoodTypeDTO {
                Id = f.Id,
                Name = f.Name
            }),
            Services = model.Services.Select(s => new ResponseServiceDTO {
                Id = s.Id,
                Name = s.Name
            })
        };

        return response;
    }

    public RestaurantModel toModel(CreateEntityCommandDto<RestaurantModel> dto)
    {
        var thisDto  = (CreateRestaurantDTO)dto;
        return new RestaurantModel{
            Name = thisDto.Name,
            Direction = thisDto.Direction,
            Id_City = thisDto.Id_City
        };
    }

    public RestaurantModel toModel(UpdateEntityCommandDto<RestaurantModel> dto, BaseEntity model)
    {
        throw new NotImplementedException();
    }
}
