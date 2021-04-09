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
    public class AdministracionController : Controller
    {
        private readonly ILogger<AdministracionController> _logger;

        public AdministracionController(ILogger<AdministracionController> logger)
        {
            _logger = logger;
        }

        public IActionResult Consecutivo()
        {

            return View();
        }

        public IActionResult EditarConsecutivo()
        {
            return View();
        }

        public IActionResult NuevoConsecutivo()
        {
            return View();
        }

        public IActionResult InfoConAero()
        {
            return View();
        }

        public IActionResult Paises()
        {
            return View();
        }

        public IActionResult Aerolineas()
        {
            return View();
        }

        public IActionResult PuertasAeropuerto()
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
