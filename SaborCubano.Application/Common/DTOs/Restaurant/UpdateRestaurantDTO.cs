using System;
using SaborCubano.Application.Common.Abstractions.DTOs;

namespace SaborCubano.Application.Common.DTOs.Restaurant;

public class UpdateRestaurantDTO : UpdateEntityCommandDto<RestaurantModel>
{
    public string Name {get; set;} = null!;

    public string? City {get; set;}

    public string Direction {get; set;} = null!;
       
    public string? Cont_Num {get; set;} = null!;

    public string? Email_Res {get; set;} = null!;

    public DateTime? Open_Date {get; set;}

    public DateTime? Close_Date {get; set;}

    public bool? Have_Home {get; set;} 

    public bool? Is_Reservas {get; set;}
    
}

