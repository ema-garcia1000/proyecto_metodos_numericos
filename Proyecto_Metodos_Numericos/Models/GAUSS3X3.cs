//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Proyecto_Metodos_Numericos.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class GAUSS3X3
    {
        public decimal IDGAUSS { get; set; }
        public decimal IDUSUARIO { get; set; }
        public string TIPOMATRIZ { get; set; }
        public string DATOSMATRIZ { get; set; }
        public decimal X { get; set; }
        public decimal Y { get; set; }
        public decimal Z { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}