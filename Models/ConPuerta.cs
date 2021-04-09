using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace V_VuelosServiciosWeb.Models
{
    public class ConPuerta
    {
        public int ID_CONSECUTIVO_PUERTA { get; set; }
        public string CONSECUTIVO_PUERTA1 { get; set; }
        public string PREFIJO_PUERTA { get; set; }
        public Nullable<int> RANGO_INICIAL_PUERTA { get; set; }
        public Nullable<int> RANGO_FINAL_PUERTA { get; set; }
    }
}