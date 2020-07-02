using System.ComponentModel.DataAnnotations;

namespace Proyectoint.Models
{
    public class Candidato
    {
        [Key]
        public int IdCandidato { get; set; }

        [Required(ErrorMessage = "Se requiere la empresa")]
        [MinLength(4, ErrorMessage = "El nombre de la empresa debe tener al menos 4 letras")]
        public string Empresa { get; set; }

        [Required(ErrorMessage = "Se requiere el primer nombre")]
        [MinLength(4, ErrorMessage = "El primer nombre debe tener al menos 4 letras")]
        public string Nombre { get; set; }

        public int Edad { get; set; }

        public string Nacionalidad { get; set; }
        [Required(ErrorMessage = "Se requiere el correo electronico")]
        [Display(Name = "Email", Prompt = "Email")]
        [DataType(DataType.EmailAddress)]
        public string Correo { get; set; }




    }
}
