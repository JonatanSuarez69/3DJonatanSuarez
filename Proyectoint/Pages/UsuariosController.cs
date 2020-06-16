using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Proyectoint.Pages
{
    public class UsuariosController : Controller
    {
        [HttpPost]

        public IActionResult getUsuarios(String Nombre_Usuario, string Contraseña)
        {

            var Usuario = context.UsuariosdbSet.Where(s => s.Nombre_Usuarios == Nombre_Usuario && s.Contraseña == Contraseña);

            if (Usuario.Any())
            {
                if (Usuario.Where(s => s.Nombre_Usuarios == Nombre_Usuario && s.Contraseña == Contraseña).Any())
                {
                    return Json(new { Status = true, message = "Bienvenido" });
                }
                else
                {
                    return Json(new { Status = false, message = "Contraseña incorrecta" });
                }


            }
            else
            {
                return Json(new { Status = true, message = "Usuario incorrecta" });
            }
        }
    }
}