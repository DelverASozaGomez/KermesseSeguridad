//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace KermesseApp.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_gastos
    {
        public int id_gasto { get; set; }
        public int id_kermesse { get; set; }
        public int id_cat_gasto { get; set; }
        public System.DateTime fecha_gasto { get; set; }
        public string concepto { get; set; }
        public decimal monto { get; set; }
        public int estado { get; set; }
        public int usuario_creacion { get; set; }
        public Nullable<int> usuario_modificacion { get; set; }
        public Nullable<int> usuario_eliminacion { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_eliminacion { get; set; }
    
        public virtual tbl_cat_gastos tbl_cat_gastos { get; set; }
        public virtual tbl_kermesse tbl_kermesse { get; set; }
        public virtual tbl_usuario tbl_usuario { get; set; }
        public virtual tbl_usuario tbl_usuario1 { get; set; }
        public virtual tbl_usuario tbl_usuario2 { get; set; }
    }
}
