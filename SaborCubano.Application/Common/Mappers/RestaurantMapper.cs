using System;
using api.Models;
using SaborCubano.Application.DTOs.Restaurant;

namespace SaborCubano.Application.Commons.Mappers;

public static class RestaurantMapper
{
    public static RestaurantDTO toRestaurantDTO(this Restaurant entity){
        return new RestaurantDTO{
            Id = entity.Id, 
            Name = entity.Name,
            Direction = entity.Direction,
            Close_Date = entity.Close_Date,
            Cont_Num = entity.Cont_Num,
            Email_Res = entity.Email_Res,
            Open_Date = entity.Open_Date,
            Chief = entity.Chief,
            City = entity.City,
        };
    }
}
