using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Metodos_Numericos.Datos
{
    public class Secante
    {
        public decimal IdSecante { get; set; }
        public decimal IdUsuario { get; set; }
        public string Ecuacion { get; set; }
        public decimal X0 { get; set; }
        public decimal X1 { get; set; }
        public decimal Xi { get; set; }
        public decimal Ea { get; set; }
    }
}