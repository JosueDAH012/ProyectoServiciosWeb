using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace V_VuelosServiciosWeb.Models
{
    public class Usuario
    {
        public int ID_USUARIO { get; set; }
        public string NOMBRE_USUARIO { get; set; }
        public string CLAVE_USUARIO { get; set; }
        public string EMAIL_USUARIO { get; set; }
        public string PREGUNTA_SEGURIDAD_USUARIO { get; set; }
        public string RESPUESTA_SEGURIDAD_USUARIO { get; set; }
        public Nullable<int> ID_ROLFK { get; set; }
    }
}

