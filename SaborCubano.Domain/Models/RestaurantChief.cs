using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class RestaurantChief : User
    {
        public ICollection<Restaurant>? Restaurants { get; set;}
    }
}