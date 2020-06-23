using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proyectoint.Models;

namespace Proyectoint.Controladores
{
    public class UsuariosController : Controller
    {

        public Proyecto_integradorContext _context;
        public UsuariosController(Proyecto_integradorContext master)
        {
            this._context = master;


        }


        [HttpPost]
        public IActionResult GetUsuario(string NombreUsuario, string Contraseña )
        {
            var usuario = _context.Usuarios.Where(s => s.NombreUsuario == NombreUsuario && s.Contraseña == Contraseña);

            if (usuario.Any())
            {
                if (usuario.Where(s => s.NombreUsuario == NombreUsuario && s.Contraseña == Contraseña).Any())
                {
                    return Json(new { status = true, message = "Bienvenido" });
                }
                else
                {
                    return Json(new { status = false, message = "Contraseña incorrecta" });
                }
            }
            else 
            {
                return Json(new { status = false, message = "Usuario incorrecto" });
            }



        }
    }
}