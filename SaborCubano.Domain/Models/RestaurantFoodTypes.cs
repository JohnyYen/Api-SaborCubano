using System;

namespace SaborCubano.Domain.Models;

public class RestaurantFoodTypes : BaseEntity
{
    [ForeignKey(nameof(Restaurant))]
    public int Id_Res {get; set;}
    public Restaurant Restaurant {get; set;};

    [ForeignKey(nameof(FoodType))]
    public int Id_FoodTypes {get; set;}
    public FoodType FoodType {get; set;}

}
