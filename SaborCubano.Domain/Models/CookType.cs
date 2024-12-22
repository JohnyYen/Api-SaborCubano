using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain;

namespace api.Models
{

    [Table("CookType")]
    public class CookType : BaseEntity
    {     
        public string Name {get; set;} = null!;

        public ICollection<Plate>? Plates {get; set;}
    }
}