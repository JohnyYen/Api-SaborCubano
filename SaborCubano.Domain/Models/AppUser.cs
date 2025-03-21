using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain.Models;

namespace api.Models
{
    public class AppUser : User
    {
        [ForeignKey(nameof(City))]
        public int Id_City {get; set;}
        public City? City {get; set;}
        public ICollection<AppUser>? AppUsers {get; set;}
        [Column(TypeName = "bytea[]")]
        public ICollection<byte[]>? Gallery {get; set;}
        public ICollection<AppUserActivity>? Activities {get; set;}
        public ICollection<CouponAppUser>? Coupon {get; set;}
    }
}