using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using SaborCubano.Domain;

namespace api.Models
{
    [Table("Restaurant")]
    public class Restaurant : BaseEntity
   {    
        [ForeignKey(nameof(City))]
        public int Id_City {get; set;}

        public City? City {get; set;}

        public string Name {get; set;} = null!;

        public string Direction {get; set;} = null!;
       
        public string? Cont_Num {get; set;} = null!;

        public string? Email_Res {get; set;} = null!;

        public DateTime? Open_Date {get; set;}

        public DateTime? Close_Date {get; set;}

        public bool? Have_Home {get; set;} 

        public bool? Is_Reservas {get; set;}

        [ForeignKey(nameof(Chief))]
        public int? Id_User {get; set;}
        public RestaurantChief? Chief {get; set;}


        public ICollection<RestaurantBussinesType>? RestaurantBussinesTypes {get; set;}

        public ICollection<RestaurantFoodTypes>? RestaurantFoodTypes {get; set;}

        public ICollection<RestaurantService>? RestaurantServices {get; set;}

        public ICollection<Coupon>? Coupons {get; set;}
    }
}