using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using V_VuelosServiciosWeb.Models;

namespace V_VuelosServiciosWeb.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;

        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            Listas.ClientesData = new List<Cliente>();

            return View();
        }

        public IActionResult Login()
        {
            return View();
        }

        public IActionResult ForgotPwd()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        /*
         public ActionResult destinos()
        {
            List<string> model = new List<string>();

            model.Add("Costa Rica");
            model.Add("India");
            model.Add("Japan");
            model.Add("Korea");
            model.Add("Laos");
            model.Add("Myanmar");
            model.Add("Singapore");
            model.Add("Thailand");

            return PartialView("~/Views/Vuelos/_Destinos.cshtml", model);
        }

        public ActionResult guardarDatos(FormCollection datos)
        {
            string desde = datos["from"];
            string hasta = datos["to"];
            string departure = datos["deparure"];
            string round = datos["trip"];

            return null;
        }

        public async Task<ActionResult> iniciarSesion(FormCollection datos)
        {
            string user = datos["uname"];
            string pass = datos["psw"];
            bool acceso = false;

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage resp = await client.GetAsync("GetClientes?username_cliente=" + user);

                if (resp.IsSuccessStatusCode)
                {
                    var datos_json = resp.Content.ReadAsStringAsync().Result;

                    globales.ClientesData = JsonConvert.DeserializeObject<List<Cliente>>(datos_json);

                    var existeusr = globales.ClientesData.Where(x => x.USERNAME_CLIENTE == user).Select(x => x.CLAVE_CLIENTE).FirstOrDefault();

                    if (string.Equals(existeusr, pass))
                    {
                        acceso = true;
                        return View("Pruebas");
                    }
                }
            }
            return null;
        }


        public ActionResult ObtenerDatosUsuario(FormCollection datos)
        {
            return null;
        }

        public ActionResult IngresarDatos(FormCollection datos)
        {
            string username = datos["User"];
            string pass = datos["Pass"];
            string email = datos["Email"];
            string name = datos["Name"];
            string last1 = datos["lastname1"];
            string last2 = datos["lastname2"];

            Cliente client = new Cliente();
            client.NOMBRE_CLIENTE = name;
            client.PRIMER_APELLIDO_CLIENTE = last1;
            client.SEGUNDO_APELLIDO_CLIENTE = last2;
            client.EMAIL_CLIENTE = email;
            client.USERNAME_CLIENTE = username;
            client.CLAVE_CLIENTE = pass;

            bool respuesta = PostInfo("InsertClient", client).Result;

            if (respuesta)
            {
                return View("~/Views/vuelos/Login.cshtml");
            }
            return null;
        }

        public async Task<bool> PostInfo(string requestParamsn, Cliente datos = null)
        {
            //DataTable responseObj = new DataTable();
            var jsonda = JsonConvert.SerializeObject(datos);
            var buffer = System.Text.Encoding.UTF8.GetBytes(jsonda);
            var byteContent = new ByteArrayContent(buffer);
            byteContent.Headers.ContentType = new MediaTypeHeaderValue("application/json");

            using (var usuario = new HttpClient())
            {
                usuario.BaseAddress = new Uri(url);
                HttpResponseMessage resp = await usuario.PostAsync(requestParamsn, byteContent).ConfigureAwait(false);

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

        public async Task<ActionResult> UserVerify(FormCollection datos)
        {
            string user = datos["uname"];
            ViewBag.username = user;
            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);

                HttpResponseMessage resp = await client.GetAsync("GetClienteID?username_cliente=" + user);

                if (resp.IsSuccessStatusCode)
                {
                    var datos_json = resp.Content.ReadAsStringAsync().Result;

                    globales.ClientesData = JsonConvert.DeserializeObject<List<Cliente>>(datos_json);
                    
                    return View("ResetPassword");
                }
                else
                {
                    return null;
                }
            }
        }

        public ActionResult PasswordReset(FormCollection datos)
        {
            string password = datos["psw2"];
            string username = datos["username"];

            List<KeyValuePair<string, string>> allIputParams = new List<KeyValuePair<string, string>>();
            string requestParams = string.Empty;

            // Converting Request Params to Key Value Pair.  



            allIputParams.Add(new KeyValuePair<string, string>("username", username));
            allIputParams.Add(new KeyValuePair<string, string>("contrasena", password));

            requestParams = new FormUrlEncodedContent(allIputParams).ReadAsStringAsync().Result;

            bool respuesta = PutInfo("ActualizaContrasena?" + requestParams).Result;

            if (respuesta)
            {
                return View("Login");
            }

            return View("ResetPassword");
        }

        public async Task<bool> PutInfo (string requestParamsn)
        {
            //DataTable responseObj = new DataTable();

            using (var client = new HttpClient())
            {
                client.BaseAddress = new Uri(url);
                HttpResponseMessage resp = await client.PutAsync(requestParamsn,null).ConfigureAwait(false);

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
         */

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
