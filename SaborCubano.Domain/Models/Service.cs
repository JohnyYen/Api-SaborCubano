using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain;
using SaborCubano.Domain.Models;

namespace api.Models
{
    [Table("Service")]
    public class Service : BaseEntity
    {
        public string Name {get; set;} = String.Empty;

        public ICollection<RestaurantService>? Restaurants {get; set;}
    }
}