using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace api.Entities
{
    public class Movie
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int Id {get; set;}

        [Required()]
        [MaxLength(50)]
        public string Name{get; set;}

        [Required()]
        [MaxLength(400)]
        public string Desc{get; set;} 
        
        public ICollection<Cast> Casts {get; set;} = new List<Cast>();
    
    
    }
}