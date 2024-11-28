using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain;

namespace api.Models
{
    [Table("Service")]
    public class Service : BaseEntity
    {
        public string Name {get; set;} = String.Empty;

        public ICollection<RestaurantService>? RestaurantServices {get; set;}
    }
}