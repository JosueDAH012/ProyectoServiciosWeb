using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace V_VuelosServiciosWeb.Models
{
    public class ConPais
    {
        public int ID_CONSECUTIVO_PAIS { get; set; }
        public string CONSECUTIVO_PAIS1 { get; set; }
        public string PREFIJO_PAIS { get; set; }
        public Nullable<int> RANGO_INICIAL_PAIS { get; set; }
        public Nullable<int> RANGO_FINAL_PAIS { get; set; }
    }
}