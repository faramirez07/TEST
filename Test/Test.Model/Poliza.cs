//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Test.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class Poliza
    {
        public int IdPoliza { get; set; }
        public string TipoPoliza { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public System.DateTime Inicio { get; set; }
        public int Duracion { get; set; }
        public decimal Precio { get; set; }
        public string TipoRiesgo { get; set; }
        public bool Activo { get; set; }
        public string UsuarioCreacion { get; set; }
        public System.DateTime FechaCreacion { get; set; }
    }
}