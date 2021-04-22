using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using Microsoft.AspNet.Identity;
using Microsoft.Owin.Security;
using Newtonsoft.Json;
using V_VuelosServiciosWeb.Models;

namespace V_VuelosServiciosWeb.Controllers
{
    
    public class AdminController : Controller
    {
        string url = "http://localhost:53588/";

        public ActionResult Login()
        {
            return View();
        }

        public async Task<ActionResult> ListUser()
        {
            List<USUARIO> model = new List<USUARIO>();
            bool acceso = false;

            using (var user = new HttpClient())
            {
                user.BaseAddress = new Uri(url);

                HttpResponseMessage resp = await user.GetAsync("GetUsuarios");
                if (resp.IsSuccessStatusCode)
                {
                    var datos_json = resp.Content.ReadAsStringAsync().Result;

                    model = JsonConvert.DeserializeObject<List<USUARIO>>(datos_json);

                }
            }
            return View("", model);
        }

        public async Task<ActionResult> iniciarSesion(FormCollection datos)
        {
            string user = datos["uname"];
            string pass = datos["psw"];
            bool acceso = false;

            using (var usuario = new HttpClient())
            {
                usuario.BaseAddress = new Uri(url);

                HttpResponseMessage resp = await usuario.GetAsync("GetUsuariosID?username_usuario=" + user);

                if (resp.IsSuccessStatusCode)
                {
                    var datos_json = resp.Content.ReadAsStringAsync().Result;

                    globales.UsuariosData = JsonConvert.DeserializeObject<List<USUARIO>>(datos_json);

                    var existeusr = globales.UsuariosData.Where(x => x.NOMBRE_USUARIO == user).Select(x => x.CLAVE_USUARIO).FirstOrDefault();

                    if (string.Equals(existeusr, pass))
                    {
                        acceso = true;
                        if (globales.UsuariosData[0].ID_ROLFK == 1)
                        {
                            return View("PaginaPrincipalCliente");
                        }
                        if (globales.UsuariosData[0].ID_ROLFK == 2)
                        {
                            await ListUser();
                            return View("PaginaPrincipal");
                        }
                    }
                }
                return View("Login");
            }
        }

        private servicioswebEntities1 db = new servicioswebEntities1();

        // GET: Usuario
        public async Task<ActionResult> Index()
        {
            var uSUARIO = db.USUARIO.Include(u => u.ROL);
            return View(await uSUARIO.ToListAsync());
        }


  

        public ActionResult AsignarRol()
        {
            return View();
        }

        public ActionResult CambiarPWD()
        {
            return View();
        }

        public ActionResult ConsecutivoAdmi()
        {
            return View();
        }

        public ActionResult ConsecutivoAerolineas()
        {
            return View();
        }

        public ActionResult RestablecerPwd()
        {
            return View();
        }
        public ActionResult ConsecutivoEditar()
        {
            return View();
        }

        public ActionResult ConsecutivoNuevo()
        {
            return View();
        }

        public ActionResult ConsecutivoPaises()
        {
            return View();
        }

        public ActionResult ConsecutivoPuertas()
        {
            return View();
        }

        public ActionResult ConsultaAerolineasPorPais()
        {
            return View();
        }

        public ActionResult ConsultaBitacora()
        {
            return View();
        }

        public ActionResult ConsultaErrores()
        {
            return View();
        }

        public ActionResult ConsultaPuertasActivas()
        {
            return View();
        }


        public ActionResult PaginaPrincipal()
        {
            return View();
        }

        public ActionResult CompraBoletos()
        {
            return View();
        }

        public ActionResult PaginaPrincipalCliente()
        {
            return View();
        }
        public ActionResult CompraTarjeta()
        {
            return View();
        }

        public ActionResult EasyPay()
        {
            return View();
        }
        public ActionResult LlegadaVuelos()
        {
            return View();
        }

        public ActionResult ReservarBoletos()
        {
            return View();
        }
        public ActionResult RestablecerContrasenaCliente()
        {
            return View();
        }
        public ActionResult SalidaVuelos()
        {
            return View();
        }

        public ActionResult LayoutAdmiLogin()
        {
            return View();
        }

        public ActionResult PaginaPrincipalAdmi()
        {
            return View();
        }

        // GET: Usuario
        public async Task<ActionResult> Indexx()
        {
            var uSUARIO = db.USUARIO.Include(u => u.ROL);
            return View(await uSUARIO.ToListAsync());
        }

        // GET: Usuario/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = await db.USUARIO.FindAsync(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL");
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_USUARIO,NOMBRE_USUARIO,CLAVE_USUARIO,EMAIL_USUARIO,COLOR_FAVORITO_USUARIO,ID_ROLFK")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                db.USUARIO.Add(uSUARIO);
                await db.SaveChangesAsync();
                return RedirectToAction("Indexx");
            }

            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL", uSUARIO.ID_ROLFK);
            return View(uSUARIO);
        }

        // GET: Usuario/CrearUsuario
        public ActionResult CrearUsuario()
        {
            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL");
            return View();
        }

        // POST: Usuario/CrearUsuario
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> CrearUsario([Bind(Include = "ID_USUARIO,NOMBRE_USUARIO,CLAVE_USUARIO,EMAIL_USUARIO,COLOR_FAVORITO_USUARIO,ID_ROLFK")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                db.USUARIO.Add(uSUARIO);
                await db.SaveChangesAsync();
                return RedirectToAction("Indexx");
            }

            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL", uSUARIO.ID_ROLFK);
            return View(uSUARIO);
        }

        // GET: Usuario/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = await db.USUARIO.FindAsync(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL", uSUARIO.ID_ROLFK);
            return View(uSUARIO);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_USUARIO,NOMBRE_USUARIO,CLAVE_USUARIO,EMAIL_USUARIO,COLOR_FAVORITO_USUARIO,ID_ROLFK")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSUARIO).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Indexx");
            }
            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL", uSUARIO.ID_ROLFK);
            return View(uSUARIO);
        }

        // GET: Usuario/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = await db.USUARIO.FindAsync(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // POST: Usuario/Delete/5
        [System.Web.Mvc.HttpPost, System.Web.Mvc.ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            USUARIO uSUARIO = await db.USUARIO.FindAsync(id);
            db.USUARIO.Remove(uSUARIO);
            await db.SaveChangesAsync();
            return RedirectToAction("Indexx");
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }

    public class AdminsController : GeneralController
    {
        // GET: Usuarios
        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetUsuarios")]
        public IEnumerable<USUARIO> GetUsuarios()
        {

            var usuario = db.USUARIO.ToList();

            return usuario;

        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetUsuariosID")]
        public IEnumerable<USUARIO> GetUsuariosID(string username_usuario)
        {
            var usuario = db.USUARIO.Where(x => x.NOMBRE_USUARIO == username_usuario).ToList();

            return usuario;
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("InsertUsuarios")]
        public IHttpActionResult InsertUsuarios([FromBody] USUARIO usuario)
        {
            if (ModelState.IsValid)
            {
                db.USUARIO.Add(usuario);
                db.SaveChanges();
                return Ok(usuario);
            }
            else
            {
                return BadRequest();
            }
        }

        [System.Web.Mvc.HttpPut]
        [System.Web.Mvc.Route("ActualizaUsuario")]
        public Boolean UpdateUser(string username, string email, string question, string answer, int rol)
        {
            try
            {
                var usuario = db.USUARIO.Where(x => x.NOMBRE_USUARIO == username).FirstOrDefault();

                usuario.EMAIL_USUARIO = email;
                usuario.COLOR_FAVORITO_USUARIO = answer;
                usuario.ID_ROLFK = rol;
                db.Entry(usuario).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [System.Web.Mvc.HttpPut]
        [System.Web.Mvc.Route("ActualizaContrasena")]
        public Boolean ActualizaContrasena(string username, string contrasena)
        {
            try
            {
                var cliente = db.USUARIO.Where(x => x.NOMBRE_USUARIO == username).FirstOrDefault();

                cliente.CLAVE_USUARIO = contrasena;
                db.Entry(cliente).State = System.Data.Entity.EntityState.Modified;
                db.SaveChanges();

                return true;

            }
            catch (Exception ex)
            {

                throw ex;
            }

        }

        [System.Web.Mvc.HttpDelete]
        [System.Web.Mvc.Route("DeleteUsuarios")]
        public IHttpActionResult EliminarUsuario(int id_user)
        {
            var usuario = db.USUARIO.Find(id_user);

            if (usuario != null)
            {
                db.USUARIO.Remove(usuario);
                db.SaveChanges();
                return Ok(usuario);
            }
            else
            {
                return NotFound();
            }
        }

    }
}

