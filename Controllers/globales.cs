using V_VuelosServiciosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace V_VuelosServiciosWeb.Controllers
{
    public static class globales
    {

        public static List<USUARIO> UsuariosData;

        public static List<AEROLINEA> ConAeroData;

        public static List<PAIS> ConPaisData;

        public static List<PUERTA> ConPuertaData;

        public static List<VUELO_LLEGADA> ConVueloData;

        public static List<ERROR> ErrorData;

        public static List<BITACORA> BitacoraData;

        public static List<COMPRAR_BOLETO> ComprarBoletoData;
    }
}