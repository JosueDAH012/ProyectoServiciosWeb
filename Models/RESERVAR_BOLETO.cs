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
    
    public partial class RESERVAR_BOLETO
    {
        public int ID_RESERVAR_BOLETO { get; set; }
        public string BOOKING_ID { get; set; }
        public string CANTIDAD_RESERVAR_BOLETOS { get; set; }
        public string TOTAL_RESERVAR_BOLETO { get; set; }
        public Nullable<int> ID_CLIENTEFK { get; set; }
    
        public virtual CLIENTE CLIENTE { get; set; }
    }
}
