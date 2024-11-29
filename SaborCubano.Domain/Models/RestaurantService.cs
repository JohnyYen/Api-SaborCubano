using System;
using System.ComponentModel.DataAnnotations.Schema;
using api.Models;

namespace SaborCubano.Domain.Models;

public class RestaurantService : BaseEntity
{
    [ForeignKey(nameof(Restaurant))]
    public int Id_Res {get; set;}
    public Restaurant Restaurant {get; set;} = null!;

    [ForeignKey(nameof(Service))]
    public int Id_Service {get; set;}
    public Service Service {get; set;} = null!;
}
