using System.ComponentModel.DataAnnotations;

namespace api.Models
{
    public class CasteForCreationDto
    {
        
        public int Id {get; set;}
        
        [Required (ErrorMessage ="Nombre Requerido")]
        [MaxLength(50, ErrorMessage = "nombre demasiado largo")]
        public string name {get; set;}
        
        [Required (ErrorMessage ="Personaje Requerido")]
        [MaxLength(50, ErrorMessage = "Personaje demasiado largo")]
        public string Character {get; set;} 
    } 
}