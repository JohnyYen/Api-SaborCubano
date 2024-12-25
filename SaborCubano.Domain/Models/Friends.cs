using System;
using System.ComponentModel.DataAnnotations.Schema;
using api.Models;

namespace SaborCubano.Domain.Models;

public class Friends : BaseEntity
{
    [ForeignKey(nameof(AppUser))]
    public string Id_User {get; set;} = null!;
    public AppUser User {get; set;} = null!;

    [ForeignKey(nameof(AppUser))]
    public string Id_Friend {get; set;} = null!;
    public AppUser Friend {get; set;} = null!;
}
