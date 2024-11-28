using System;

namespace SaborCubano.Domain.Models;

public class CouponAppUser : BaseEntity
{
    [ForeignKey(nameof(Coupon))]
    public int Id_Coupon {get; set;}
    public Coupon Coupon {get; set;}

    [ForeignKey(nameof(AppUser))]
    public int Id_AppUser {get; set;}
    public AppUser AppUser {get; set;}
}
