using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
namespace api.Models
{
    public class PlateReview : Review
    {
        public int Valoration_Plate {get; set;}
        public bool Eat_In_Local {get; set;}
        
        [ForeignKey(nameof(Plate))]
        public int Id_Plate {get; set;}
        public Plate? Plate {get; set;}
    }
}