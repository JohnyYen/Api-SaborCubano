using System;

namespace SaborCubano.Domain.Models;

public class PlateCookType : BaseEntity
{
    [ForeignKey(nameof(Plate))]
    public int Id_Plate {get; set;}
    public Plate Plate {get; set;}

    [ForeignKey(nameof(CookType))]
    public int Id_CT {get; set;}
    public CookType CookType {get; set;}
}
