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
    [Table("Plate")]
    public class Plate : BaseEntity
    {
       
        [ForeignKey(nameof(Restaurant))]
        public int Id_Res {get; set;}
        public Restaurant? Restaurant {get; set;}

        public string Name {get; set;} = null!;

        public string Description {get; set;} = null!;

        public float Price {get; set;}

        public float Calories {get; set;}

        public ICollection<Ingredient>? Ingredients {get; set;}
        public ICollection<CookType>? CookTypes {get; set;}
        public ICollection<Allergense>? Allergenses {get; set;}

    }
}