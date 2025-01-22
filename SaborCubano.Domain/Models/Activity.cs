using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain;
using SaborCubano.Domain.Models;

namespace api.Models
{
    [Table("Activities")]
    public class Activity : BaseEntity
    {
        
        public string Name {get; set;} = null!;
        public double Score {get; set;}
        public ICollection<AppUser>? AppUser {get; set;}
    }
}