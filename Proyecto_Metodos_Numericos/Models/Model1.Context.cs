﻿//------------------------------------------------------------------------------
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
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    
    public partial class Entities_Metodos : DbContext
    {
        public Entities_Metodos()
            : base("name=Entities_Metodos")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<USUARIO> USUARIO { get; set; }
        public virtual DbSet<GAUSS3X3> GAUSS3X3 { get; set; }
        public virtual DbSet<NEWTON> NEWTON { get; set; }
        public virtual DbSet<SECANTE> SECANTE { get; set; }
        public virtual DbSet<MULLER> MULLER { get; set; }
    }
}
