using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;


namespace V_VuelosServiciosWeb.Controllers
{
    public class loginController : Controller
    {
        // GET: login
        public ActionResult Login()
        {
            return View();
        }
    }
}