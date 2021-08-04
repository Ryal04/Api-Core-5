using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CastForUpdateDto
    {   
        [Required (ErrorMessage ="Nombre Requerido")]
        [MaxLength(50, ErrorMessage = "nombre demasiado largo")]
        public string name {get; set;}
        
        
        [MaxLength(50, ErrorMessage = "Personaje demasiado largo")]
        public string Character {get; set;} 
        
    }
}