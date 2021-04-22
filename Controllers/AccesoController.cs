using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace V_VuelosServiciosWeb.Controllers
{
    public class AccesoController : Controller
    {
        // GET: Acceso
        public ActionResult LogIn()
        {
            return View();
        }

        [HttpPost]
        public ActionResult Login(string usuario, string inputPassword)
        {
            try
            {
                using (Models.servicioswebEntities1 db = new Models.servicioswebEntities1())
                {
                    var oUser = (from d in db.USUARIO
                                 where d.EMAIL_USUARIO == usuario.Trim() && d.CLAVE_USUARIO == inputPassword.Trim()
                                 select d).FirstOrDefault();
                    if (oUser == null)
                    {
                        ViewBag.Error = "Usuario o contraseña invalida";
                        return View();
                    }
                    else
                    {
                        Session["User"] = oUser;
                        if (oUser.ID_ROLFK == 2)
                        {
                            return RedirectToAction("PaginaPrincipalCliente", "Admin");
                        }
                    }

                    

                }

                return RedirectToAction("LogIn", "Admin");
            }
            catch (Exception ex)
            {
                ViewBag.Error = ex.Message;
                return View();
            }

        }
    }
}