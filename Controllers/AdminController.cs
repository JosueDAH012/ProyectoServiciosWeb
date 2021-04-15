using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace V_VuelosServiciosWeb.Controllers
{
    public class AdminController : Controller
    {
        // GET: Admin
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
        
        public ActionResult CrearUsuarioCliente()
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
        public ActionResult LogInCliente()
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

        public ActionResult LayoutAdmiLogin()
        {
            return View();
        }

        public ActionResult PaginaPrincipalAdmi()
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

        public ActionResult CrearUsuario()
        {
            return View();
        }

        public ActionResult CrearUsuarioAdmi()
        {
            return View();
        }

        public ActionResult LogIn()
        {
            return View();
        }
        public ActionResult PaginaPrincipal()
        {
            return View();
        }
        // GET: Admin/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: Admin/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Admin/Create
        [HttpPost]
        public ActionResult Create(FormCollection collection)
        {
            try
            {
                // TODO: Add insert logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: Admin/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add update logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Admin/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: Admin/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, FormCollection collection)
        {
            try
            {
                // TODO: Add delete logic here

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
    }
}
