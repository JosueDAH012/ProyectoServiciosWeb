using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Newtonsoft.Json;
using V_VuelosServiciosWeb.Models;

namespace V_VuelosServiciosWeb.Controllers
{
    public class BitacoraController : Controller
    {
        string url = "http://localhost:53588/";

        public ActionResult IngresarBitacora(string USUARIO_BITACORA, string FECHA_BITACORA, string CODIGO_BITACORA, string TIPO_BITACORA,
            string DESCRIPCION_BITACORA, string DETALLE_BITACORA)
        {
            Bitacora bitacora = new Bitacora();
            bitacora.USUARIO_BITACORA = USUARIO_BITACORA;
            bitacora.FECHA_BITACORA = FECHA_BITACORA;
            bitacora.CODIGO_BITACORA = CODIGO_BITACORA;
            bitacora.TIPO_BITACORA = TIPO_BITACORA;
            bitacora.DESCRIPCION_BITACORA = DESCRIPCION_BITACORA;
            bitacora.DETALLE_BITACORA = DETALLE_BITACORA;

            bool respuesta = PostInfo("InsertBitacora", bitacora).Result;

            return null;
        }
        public async Task<bool> PostInfo(string requestParamsn, Bitacora datos = null)
        {
            //DataTable responseObj = new DataTable();
            var jsonda = JsonConvert.SerializeObject(datos);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonda);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (var bitacora = new HttpClient())
            {
                bitacora.BaseAddress = new Uri(url);
                HttpResponseMessage resp = await bitacora.PostAsync(requestParamsn, byteContent).ConfigureAwait(false);
                if (resp.StatusCode == System.Net.HttpStatusCode.OK)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
        }
    }
}
