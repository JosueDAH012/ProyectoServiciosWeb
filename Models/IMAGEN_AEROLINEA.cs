//------------------------------------------------------------------------------
// <auto-generated>
//     Este código se generó a partir de una plantilla.
//
//     Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//     Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace V_VuelosServiciosWeb.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class IMAGEN_AEROLINEA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public IMAGEN_AEROLINEA()
        {
            this.AEROLINEA = new HashSet<AEROLINEA>();
        }
    
        public int ID_IMAGEN_AEROLINEA { get; set; }
        public byte[] IMAGEN_AEROLINEA1 { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<AEROLINEA> AEROLINEA { get; set; }
    }
}