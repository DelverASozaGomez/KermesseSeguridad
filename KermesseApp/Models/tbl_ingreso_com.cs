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
    
    public partial class tbl_ingreso_com
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_ingreso_com()
        {
            this.tbl_ingresocom_det = new HashSet<tbl_ingresocom_det>();
        }
    
        public int id_ingresocom { get; set; }
        public int id_kermesse { get; set; }
        public int id_comunidad { get; set; }
        public int id_producto { get; set; }
        public int cant_producto { get; set; }
        public Nullable<decimal> precio_producto { get; set; }
        public int total_bonos { get; set; }
        public int usuario_creacion { get; set; }
        public Nullable<int> usuario_modificacion { get; set; }
        public Nullable<int> usuario_eliminacion { get; set; }
        public System.DateTime fecha_creacion { get; set; }
        public Nullable<System.DateTime> fecha_modificacion { get; set; }
        public Nullable<System.DateTime> fecha_eliminacion { get; set; }
        public int estado { get; set; }
    
        public virtual tbl_comunidad tbl_comunidad { get; set; }
        public virtual tbl_kermesse tbl_kermesse { get; set; }
        public virtual tbl_productos tbl_productos { get; set; }
        public virtual tbl_usuario tbl_usuario { get; set; }
        public virtual tbl_usuario tbl_usuario1 { get; set; }
        public virtual tbl_usuario tbl_usuario2 { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_ingresocom_det> tbl_ingresocom_det { get; set; }
    }
}
