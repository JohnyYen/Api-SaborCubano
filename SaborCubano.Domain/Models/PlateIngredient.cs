using System;
using System.ComponentModel.DataAnnotations.Schema;
using api.Models;

namespace SaborCubano.Domain.Models;

public class PlateIngredient : BaseEntity
{
    
    [ForeignKey(nameof(Plate))]
    public int Id_Plate {get; set;}
    public Plate Plate {get; set;} = null!;

    
    [ForeignKey(nameof(Ingredient))]
    public int Id_Ingredient {get; set;}
    public Ingredient Ingredient {get; set;}  = null!;
}
