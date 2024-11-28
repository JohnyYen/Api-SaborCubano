using System;

namespace SaborCubano.Domain.Models;

public class PlateIngredient : BaseEntity
{
    [ForeignKey(nameof(Plate))]
    public int Id_Plate {get; set;}
    public plate Plate {get; set;}

    [ForeignKey(nameof(Ingredient))]
    public int Id_Ingredient {get; set;}
    public Ingredient Ingredient {get; set;}
}
