using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace V_VuelosServiciosWeb.Models
{
    public class Cliente
    {

        public int ID_CLIENTE { get; set; }
        public string NOMBRE_CLIENTE { get; set; }
        public string PRIMER_APELLIDO_CLIENTE { get; set; }
        public string SEGUNDO_APELLIDO_CLIENTE { get; set; }
        public string EMAIL_CLIENTE { get; set; }
        public string USERNAME_CLIENTE { get; set; }
        public string CLAVE_CLIENTE { get; set; }

    }
}

