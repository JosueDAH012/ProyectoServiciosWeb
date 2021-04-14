using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;

namespace V_VuelosServiciosWeb.Controllers
{
    public class GeneralController : ApiController
    {
        public DatebaseVuelosEntities db;

        public GeneralController()
        {
            db = new DatebaseVuelosEntities();
        }

    }
}