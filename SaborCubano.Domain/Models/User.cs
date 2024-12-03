using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;
using SaborCubano.Domain;
using SaborCubano.Domain.Commons;
namespace api.Models
{
    [Table("User")]
    public abstract class User : IdentityUser
    {
        public string User_Name { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

    }
}