using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using api.Models;

namespace SaborCubano.Domain.Models
{
    public class AppUserActivity : BaseEntity
    {
        [ForeignKey(nameof(AppUser))]
        public int Id_User {get; set;}
        public AppUser AppUser {get; set;} = null!;

        [ForeignKey(nameof(Activity))]
        public int Id_Activity {get; set;}
        public Activity Activity {get; set;} = null!;
    }
}