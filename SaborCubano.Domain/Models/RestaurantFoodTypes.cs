using System;
using System.ComponentModel.DataAnnotations.Schema;
using api.Models;

namespace SaborCubano.Domain.Models;

public class RestaurantFoodTypes : BaseEntity
{
    [ForeignKey(nameof(Restaurant))]
    public int Id_Res {get; set;}
    public Restaurant Restaurant {get; set;} = null!;

    [ForeignKey(nameof(FoodType))]
    public int Id_FoodTypes {get; set;}
    public FoodType FoodType {get; set;} = null!;

}
