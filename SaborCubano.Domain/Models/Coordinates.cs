using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using SaborCubano.Domain;

namespace SaborCubano.Domain.Models;

[Table("Coordinates")]
public class Coordinates : BaseEntity
{
    public float Latitude { get; set; }
    public float Longitude { get; set; }

    public int Id_Res {get; set;}
    public Restaurant Restaurant {get; set;} = null!;
}
