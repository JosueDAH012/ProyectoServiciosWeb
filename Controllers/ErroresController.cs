using Newtonsoft.Json;
using V_VuelosServiciosWeb.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using System.Web;
using Microsoft.AspNetCore.Mvc;

namespace V_VuelosServiciosWeb.Controllers
{
    public class ErroresController : Controller
    {
        string url = "http://localhost:53588/";
        // GET: Errores
        public ActionResult ReportesErrores()
        {
            return View();
        }


        public ActionResult IngresarErrores(string date, string message)
        {
            Error error = new Error();
            error.FECHA_ERROR = date;
            error.MENSAJE_ERROR = message;
            bool respuesta = PostInfo("InsertError", error).Result;
            return null;
        }

        public async Task<bool> PostInfo(string requestParamsn, Error datos = null)
        {
            //DataTable responseObj = new DataTable();
            var jsonda = JsonConvert.SerializeObject(datos);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonda);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");
            using (var error = new HttpClient())
            {
                error.BaseAddress = new Uri(url);
                HttpResponseMessage resp = await error.PostAsync(requestParamsn, byteContent).ConfigureAwait(false);
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