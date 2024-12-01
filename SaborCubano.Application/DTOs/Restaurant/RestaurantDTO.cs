using System;
using api.Models;

namespace SaborCubano.Application.DTOs.Restaurant;

public class RestaurantDTO
{
    public int Id {get; set;}
    public string Name {get; set;} = null!;

    public string Direction {get; set;} = null!;
    public string? Cont_Num {get; set;} = null!;
    public string? Email_Res {get; set;} = null!;
    public DateTime? Open_Date {get; set;}
    public DateTime? Close_Date {get; set;}

    public City? City {get; set;}
    public RestaurantChief? Chief {get; set;}
}
