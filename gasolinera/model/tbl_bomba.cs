//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace gasolinera.model
{
    using System;
    using System.Collections.Generic;
    
    public partial class tbl_bomba
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public tbl_bomba()
        {
            this.tbl_realiza = new HashSet<tbl_realiza>();
            this.tbl_venta = new HashSet<tbl_venta>();
        }
    
        public int bmb_codigo { get; set; }
        public string bmb_tipo { get; set; }
        public string bmb_estado { get; set; }
        public Nullable<int> est_codigo { get; set; }
    
        public virtual tbl_estacion tbl_estacion { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_realiza> tbl_realiza { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<tbl_venta> tbl_venta { get; set; }
    }
}
