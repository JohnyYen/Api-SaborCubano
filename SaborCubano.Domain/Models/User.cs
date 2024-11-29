using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain;
namespace api.Models
{
    [Table("User")]
    public abstract class User : BaseEntity
    {
        public string Email { get; set; } = String.Empty;
        public string User_Name { get; set; } = String.Empty;
        public string Password { get; set; } = String.Empty;

    }
}