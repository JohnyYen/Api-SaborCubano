using System;

namespace SaborCubano.Domain.Models;

public class RestaurantService : BaseEntity
{
    [ForeignKey(nameof(Restaurant))]
    public int Id_Res {get; set;}
    public Restaurant Restaurant {get; set;}

    [ForeignKey(nameof(Service))]
    public int Id_Service {get; set;}
    public Service Service {get; set;}
}
