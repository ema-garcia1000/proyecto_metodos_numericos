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
    
    public partial class NEWTON
    {
        public decimal IDNEWTON { get; set; }
        public decimal IDUSUARIO { get; set; }
        public string ECUACION { get; set; }
        public decimal X0 { get; set; }
        public decimal XI { get; set; }
        public decimal EAA { get; set; }
    
        public virtual USUARIO USUARIO { get; set; }
    }
}