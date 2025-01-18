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
    [Table("BussinesType")]
    public class BussinesType : BaseEntity
    {
        public string Name {get; set;} = null!;

        public ICollection<Restaurant>? RestaurantBussinesTypes {get; set;}
    }
}