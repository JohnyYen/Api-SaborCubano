using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Restaurant;

public class CreateRestaurantDTO : CreateEntityCommandDto<RestaurantModel>
{
    public string Name {get; set;} = null!;
    public int Id_City {get; set;}
    public string Direction {get; set;} = null!;
    public IEnumerable<int> Ids_Service{get; set;} = null!;
    public IEnumerable<int> Ids_FoodType{get; set;} = null!;
    public IEnumerable<int> Ids_BussinesType{get; set;} = null!;
}
