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
    public class SeguridadController : Controller
    {
        private readonly ILogger<SeguridadController> _logger;

        public SeguridadController(ILogger<SeguridadController> logger)
        {
            _logger = logger;
        }

        public IActionResult CrearUsuario()
        {
            return View();
        }

        public IActionResult CambiarPWD()
        {
            return View();
        }

        public IActionResult AsignarRoles()
        {
            return View();
        }

        public IActionResult Usuario()
        {
            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
