using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Models;
using SaborCubano.Domain;
using SaborCubano.Domain.Models;

namespace api.Models
{
    [Table("Restaurant")]
    public class Restaurant : BaseEntity
   {    
        [ForeignKey(nameof(City))]
        public int Id_City {get; set;}

        public City City {get; set;} = null!;

        public string Name {get; set;} = null!;

        public string Direction {get; set;} = null!;
       
        public string? Cont_Num {get; set;} = null!;

        public string? Email_Res {get; set;} = null!;

        public DateTime? Open_Date {get; set;}

        public DateTime? Close_Date {get; set;}

        public bool? Have_Home {get; set;} 

        public bool? Is_Reservas {get; set;}

        [ForeignKey(nameof(Coordinates))]
        public int? Id_Coord {get; set;}
        public Coordinates? Coordinates {get; set;}

        [ForeignKey(nameof(Chief))]
        public string? Id_User {get; set;}
        public RestaurantChief? Chief {get; set;}
        
        public ICollection<BussinesType> BussinesTypes {get; set;} = new List<BussinesType>();

        public ICollection<FoodType> FoodTypes {get; set;} = new List<FoodType>();

        public ICollection<Service> Services {get; set;} = new List<Service>();

        public ICollection<Coupon>? Coupons {get; set;}
    }
}