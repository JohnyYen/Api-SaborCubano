using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;
using SaborCubano.Domain;

namespace api.Models
{
    [Table("Review")]
    public abstract class Review : BaseEntity
    { 

        public string Name {get; set;} = null!;

        public string Opinion {get; set;} = null!;

        [Column(TypeName = "bytea[]")]
        public ICollection<byte[]>? Photos {get; set;}

        public DateTime? DateWriting {get; set;}
    
        public bool Is_Util {get; set;}
        public bool Is_Funny {get; set;}


    }
}