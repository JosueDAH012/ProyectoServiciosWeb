using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace V_VuelosServiciosWeb.Models
{
    public class ComprarBoleto
    {
        public int ID_BOLETO { get; set; }
        public int ID_CLIENTEFK { get; set; }
        public string FECHA_COMPRAR_BOLETO { get; set; }
        public string PAGO_COMPRAR_BOLETO { get; set; }
        public int MONTO_COMPRAR_BOLETO { get; set; }
    }
}