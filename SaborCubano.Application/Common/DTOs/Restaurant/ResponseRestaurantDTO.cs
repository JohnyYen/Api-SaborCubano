using System;
using api.Models;
using SaborCubano.Application.Common.Abstractions.DTOs;
using SaborCubano.Application.Common.DTOs.Bussines_Type;
using SaborCubano.Application.Common.DTOs.City;
using SaborCubano.Application.Common.DTOs.Food_Type;
using SaborCubano.Application.Common.DTOs.Service;

namespace SaborCubano.Application.Common.DTOs.Restaurant;

public class ResponseRestaurantDTO : ResponseDto<RestaurantModel>
{
    public string Name {get; set;} = null!;
    public string Direction {get; set;} = null!;
    public ResponseCityDTO City {get; set;} = null!;

    public string? Cont_Num {get; set;}

    public string? Email_Res {get; set;} = null!;

    public DateTime? Open_Date {get; set;}

    public DateTime? Close_Date {get; set;}

    public bool? Have_Home {get; set;} 

    public bool? Is_Reservas {get; set;}

    public IEnumerable<ResponseServiceDTO> Services {get; set;} = new List<ResponseServiceDTO>();
    public IEnumerable<ResponseBussinesTypeDTO> BussinesTypes {get; set;} = new List<ResponseBussinesTypeDTO>();
    public IEnumerable<ResponseFoodTypeDTO> FoodTypes {get; set;} = new List<ResponseFoodTypeDTO>(); 
}
