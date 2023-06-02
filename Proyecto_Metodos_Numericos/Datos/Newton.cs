using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Metodos_Numericos.Datos
{
    public class Newton
    {
        public decimal IdNewton { get; set; }
        public decimal IdUsuario { get; set; }
        public string Ecuacion { get; set; }
        public decimal X0 { get; set; }
        public string Xi { get; set; }
        public string Ea { get; set; }
    }
}