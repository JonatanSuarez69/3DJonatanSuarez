using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyectoint.Models
{
   
    public class Persona 
    {
        [Required(ErrorMessage = "Se requiere el primer nombre")]
        [MinLength(4, ErrorMessage ="El primer nombre debe tener al menos 4 letras")]
        [Display(Name ="Nombre",Prompt ="Nombre")]
        public string Nombre { get; set; }
        [Required(ErrorMessage = "Se requien los apellidos")]
        [MinLength(4, ErrorMessage = "Los apellidos deben tener al menos 4 letras")]
        [Display(Name = "Apellidos", Prompt="Apellidos")]
        public string Apellidos { get; set; }
        [Required(ErrorMessage = "Se requiere el correo electronico")]
        [Display(Name = "Email", Prompt = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }

    }
}
