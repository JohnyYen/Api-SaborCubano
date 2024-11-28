using System;
using System.Collections.Generic;
using SaborCubano.Domain;

namespace api.Models;

public partial class Allegense : BaseEntity
{
   
    public string Name { get; set; } = null!;
    
    public virtual ICollection<Plate>? Plates { get; set; }
}
