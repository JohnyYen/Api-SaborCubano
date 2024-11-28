using System;

namespace SaborCubano.Domain.Models;

public class RestaurantBussinesType : BaseEntity
{
    [ForeignKey(nameof(BussinesType))]
    public int Id_BS {get; set;}
    public BussinesType BussinesType {get; set;}

    [ForeignKey(nameof(Restaurant))]
    public int Id_Res {get; set;}
    public Restaurant Restaurant {get; set;}
}
