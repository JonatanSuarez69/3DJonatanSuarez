using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Proyectoint.Models
{
    [Table("Usuarios",Schema ="dbo")]
    public partial class Usuarios
    {
        [Key]
        public int Id_usuario { get; set; }
        [Display(Name ="Nombre de usuario")]
        public string Nombre_Usuario { get; set; }
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }
    }
}


