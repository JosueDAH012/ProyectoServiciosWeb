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
    
    public partial class USUARIO
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public USUARIO()
        {
            this.COMPRAR_BOLETO = new HashSet<COMPRAR_BOLETO>();
            this.RESERVAR_BOLETO = new HashSet<RESERVAR_BOLETO>();
            this.TARJETA = new HashSet<TARJETA>();
        }
    
        public int ID_USUARIO { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string CLAVE_USUARIO { get; set; }
        public string EMAIL_USUARIO { get; set; }
        public string COLOR_FAVORITO_USUARIO { get; set; }
        public Nullable<int> ID_ROLFK { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<COMPRAR_BOLETO> COMPRAR_BOLETO { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RESERVAR_BOLETO> RESERVAR_BOLETO { get; set; }
        public virtual ROL ROL { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<TARJETA> TARJETA { get; set; }
    }
}
