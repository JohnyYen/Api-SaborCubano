using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace api.Models
{
    public class RestaurantReview : Review
    {
        public int Valoration_Local {get; set;}
        public int Valoration_Service {get; set;}
        public int Valoration_Price {get; set;}
        public int Valoration_Higiene {get; set;}

        [ForeignKey(nameof(Restaurant))]
        public int Id_Res {get; set;}
        public Restaurant? Restaurant {get; set;}
    }
}