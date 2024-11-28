using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain;

namespace api.Models
{
    [Table("FoodType")]
    public class FoodType : BaseEntity
    {
    
        public string Name {get; set;} = null!;

        public ICollection<RestaurantFoodTypes>? RestaurantFoodTypes {get; set;}
    }
}