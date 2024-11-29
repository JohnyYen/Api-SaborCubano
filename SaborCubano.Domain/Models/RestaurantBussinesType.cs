using System;
using System.ComponentModel.DataAnnotations.Schema;
using System.Data;
using api.Models;

namespace SaborCubano.Domain.Models;

public class RestaurantBussinesType : BaseEntity
{
    [ForeignKey(nameof(BussinesType))]
    public int Id_BS {get; set;}
    public BussinesType BussinesType {get; set;} = null!;

    [ForeignKey(nameof(Restaurant))]
    public int Id_Res {get; set;}
    public Restaurant Restaurant {get; set;} = null!;
}
