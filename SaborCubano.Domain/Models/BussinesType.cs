using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain;

namespace api.Models
{
    [Table("BussinesType")]
    public class BussinesType : BaseEntity
    {
        public string Name {get; set;} = null!;

        public ICollection<RestaurantBussinesType>? RestaurantBussinesTypes {get; set;}
    }
}