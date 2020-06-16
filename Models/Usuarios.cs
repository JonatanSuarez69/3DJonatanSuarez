using System;
using System.Collections.Concurrent;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace Models
{
    [Table("Usuarios", Schema = "dbo")]
    public class Usuarios
    {
        [Key]
        public int Id_Usuarios { get; set; }
        [Display(Name="Nombre de usuario")]
        public string Nombre_Usuario { get; set; }
        [Display(Name = "Contraseña")]
        [DataType(DataType.Password)]
        public string Contraseña { get; set; }


    }
}
