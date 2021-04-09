using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace V_VuelosServiciosWeb.Models
{
    public class ConVuelo
    {
        public int ID_CONSECUTIVO_VUELO { get; set; }
        public string CONSECUTIVO_VUELO1 { get; set; }
        public string PREFIJO_VUELO { get; set; }
        public Nullable<int> RANGO_INICIAL_VUELO { get; set; }
        public Nullable<int> RANGO_FINAL_VUELO { get; set; }
    }
}