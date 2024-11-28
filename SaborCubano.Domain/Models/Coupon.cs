using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using SaborCubano.Domain;

namespace api.Models
{
    [Table("Coupon")]
    public class Coupon : BaseEntity 
    {
        [ForeignKey(nameof(AppUser))]
        public int Id_User {get; set;}
        public AppUser? AppUser {get; set;} = null! ;

        [ForeignKey(nameof(Restaurant))]
        public int Id_Res {get; set;}
        public Restaurant? Restaurant {get; set;}

        public int Discount {get; set;}
        public DateTime? Active_Date {get; set;}
    }
}