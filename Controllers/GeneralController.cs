using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using V_VuelosServiciosWeb.Models;

namespace V_VuelosServiciosWeb.Controllers
{
    public class GeneralController : ApiController
    {

        public servicioswebEntities2 db;

        public GeneralController()
        {
            db = new servicioswebEntities2();
        }

    }

}