using Microsoft.AspNetCore.Mvc;
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
using Microsoft.AspNetCore.Http;

namespace V_VuelosServiciosWeb.Controllers
{
    public class ConsecutivosController : Controller
    {
        string url = "http://localhost:53588/";

        // GET: Consecutivos
        public ActionResult InfoConAero()
        {
            return View();
        }

        public ActionResult consecutivo()
        {
            List<string> model = new List<string>();

            model.Add("Airline");
            model.Add("Country");
            model.Add("Flights");
            model.Add("Airport Gates");

            return PartialView("~/Views/Consecutivos/_Consecutivos.cshtml", model);
        }

        public ActionResult IngresarDatos(FormCollection datos)
        {
            string conse = datos["Consecutivo"];
            string consecutivo = datos["consecutive"];
            string prefix = datos["prefix"];
            string initial = datos["initial"];
            string final = datos["final"];

            if (prefix == null)
            {
                prefix = "N/A";
            }
            if (initial == null)
            {
                initial = "0";
                final = "0";
            }

            int inicio = Int32.Parse(initial.ToString());
            int fin = Int32.Parse(final.ToString());

            if (conse == "Airline")
            {
                ConAerolinea con = new ConAerolinea();
                con.CONSECUTIVO_AEROLINEA1 = consecutivo;
                con.PREFIJO_AEROLINEA = prefix;
                con.RANGO_INICIAL_AEROLINEA = inicio;
                con.RANGO_FINAL_AEROLINEA = fin;

                bool respuesta = PostInfoAe("InsertConAereo", con).Result;

                if (respuesta)
                {
                    return View("InfoConAero");
                }
            }
            if (conse == "Country")
            {
                ConPais con = new ConPais();
                con.CONSECUTIVO_PAIS1 = consecutivo;
                con.PREFIJO_PAIS = prefix;
                con.RANGO_INICIAL_PAIS = inicio;
                con.RANGO_FINAL_PAIS = fin;

                bool respuesta = PostInfoCo("InsertConPais", con).Result;

                if (respuesta)
                {
                    return View("InfoConAero");
                }
            }
            if (conse == "Flights")
            {
                ConVuelo con = new ConVuelo();
                con.CONSECUTIVO_VUELO1 = consecutivo;
                con.PREFIJO_VUELO = prefix;
                con.RANGO_INICIAL_VUELO = inicio;
                con.RANGO_FINAL_VUELO = fin;

                bool respuesta = PostInfoFl("InsertConVuelo", con).Result;

                if (respuesta)
                {
                    return View("InfoConAero");
                }
            }
            if (conse == "Airport Gates")
            {
                ConPuerta con = new ConPuerta();
                con.CONSECUTIVO_PUERTA1 = consecutivo;
                con.PREFIJO_PUERTA = prefix;
                con.RANGO_INICIAL_PUERTA = inicio;
                con.RANGO_FINAL_PUERTA = fin;

                bool respuesta = PostInfoAG("InsertConPuerta", con).Result;

                if (respuesta)
                {
                    return View("InfoConAero");
                }
            }

            return null;
        }

        public async Task<bool> PostInfoAe(string requestParamsn, ConAerolinea datos = null)
        {
            //DataTable responseObj = new DataTable();
            var jsonda = JsonConvert.SerializeObject(datos);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonda);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (var consecutivo = new HttpClient())
            {
                consecutivo.BaseAddress = new Uri(url);
                HttpResponseMessage resp = await consecutivo.PostAsync(requestParamsn, byteContent).ConfigureAwait(false);

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

        public async Task<bool> PostInfoCo(string requestParamsn, ConPais datos = null)
        {
            //DataTable responseObj = new DataTable();
            var jsonda = JsonConvert.SerializeObject(datos);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonda);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (var consecutivo = new HttpClient())
            {
                consecutivo.BaseAddress = new Uri(url);
                HttpResponseMessage resp = await consecutivo.PostAsync(requestParamsn, byteContent).ConfigureAwait(false);

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

        public async Task<bool> PostInfoFl(string requestParamsn, ConVuelo datos = null)
        {
            //DataTable responseObj = new DataTable();
            var jsonda = JsonConvert.SerializeObject(datos);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonda);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (var consecutivo = new HttpClient())
            {
                consecutivo.BaseAddress = new Uri(url);
                HttpResponseMessage resp = await consecutivo.PostAsync(requestParamsn, byteContent).ConfigureAwait(false);

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

        public async Task<bool> PostInfoAG(string requestParamsn, ConPuerta datos = null)
        {
            //DataTable responseObj = new DataTable();
            var jsonda = JsonConvert.SerializeObject(datos);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonda);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (var consecutivo = new HttpClient())
            {
                consecutivo.BaseAddress = new Uri(url);
                HttpResponseMessage resp = await consecutivo.PostAsync(requestParamsn, byteContent).ConfigureAwait(false);

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