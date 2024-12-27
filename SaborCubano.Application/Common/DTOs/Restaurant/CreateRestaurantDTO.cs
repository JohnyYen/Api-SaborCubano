using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Bussines_Type;
using SaborCubano.Application.Common.DTOs.Service;

namespace SaborCubano.Application.Common.DTOs.Food_Type;

public class CreateRestaurantDTO : CreateEntityCommandDto<RestaurantModel>
{
    public string Name {get; set;} = null!;
    public string Direction {get; set;} = null!;
    public string NameCity {get; set;} = null!;
    public IEnumerable<CreateServiceDTO> services {get; set;} = null!;
    public IEnumerable<CreateBussinesTypeDTO> BussinesTypes {get; set;} = null!;
    public IEnumerable<CreateFoodTypeDTO> FoodTypes {get; set;} = null!;
}
