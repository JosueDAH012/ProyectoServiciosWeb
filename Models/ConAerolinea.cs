using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace V_VuelosServiciosWeb.Models
{
    public class ConAerolinea
    {
        public int ID_CONSECUTIVO_AEROLINEA { get; set; }
        public string CONSECUTIVO_AEROLINEA1 { get; set; }
        public string PREFIJO_AEROLINEA { get; set; }
        public Nullable<int> RANGO_INICIAL_AEROLINEA { get; set; }
        public Nullable<int> RANGO_FINAL_AEROLINEA { get; set; }
    }
}