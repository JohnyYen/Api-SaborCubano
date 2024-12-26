using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain;

namespace api.Models
{
    [Table("City")]
    public class City : BaseEntity
    {
        
        [ForeignKey(nameof(Province))]
        public int Id_Prov {get; set;}
        public Province? Province {get; set;}

        public string Name {get; set;} = String.Empty;
        
        public City (int id_Prov, string name){
            Id_Prov = id_Prov;
            Name = name;
        }
        public ICollection<Restaurant>? Restaurants {get; set;}
    }
}