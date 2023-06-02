using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Metodos_Numericos.Datos
{
    public class Usuario
    {
        public decimal IdUsuario { get; set; }
        public string Correo { get; set; }
        public string Clave { get; set; }
        public string ConfirmarClave { get; set; }
    }
}