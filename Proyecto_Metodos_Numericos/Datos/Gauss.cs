using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Proyecto_Metodos_Numericos.Datos
{
    //Para la matriz de 3x3
    public class Gauss3
    {
        public decimal IdGauss { get; set; }
        public decimal IdUsuario { get; set; }
        public string TipoMatriz { get; set; }
        public string DatosMatriz { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
    }
}