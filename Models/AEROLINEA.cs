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
    
    public partial class AEROLINEA
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public AEROLINEA()
        {
            this.VUELO_LLEGADA = new HashSet<VUELO_LLEGADA>();
            this.VUELO_SALIDA = new HashSet<VUELO_SALIDA>();
        }
    
        public string ID_AEROLINEA { get; set; }
        public string NOMBRE_AEROLINEA { get; set; }
        public Nullable<int> ID_IMAGEN_AEROLINEAFK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VUELO_LLEGADA> VUELO_LLEGADA { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<VUELO_SALIDA> VUELO_SALIDA { get; set; }
        public virtual IMAGEN_AEROLINEA IMAGEN_AEROLINEA { get; set; }
    }
}