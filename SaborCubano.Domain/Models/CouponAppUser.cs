using System;
using System.ComponentModel.DataAnnotations.Schema;
using api.Models;

namespace SaborCubano.Domain.Models;

public class CouponAppUser : BaseEntity
{
    [ForeignKey(nameof(Coupon))]
    public int Id_Coupon {get; set;}
    public Coupon Coupon {get; set;} = null!;

    [ForeignKey(nameof(AppUser))]
    public string Id_AppUser {get; set;} = null!;
    public AppUser AppUser {get; set;} = null!;
}
