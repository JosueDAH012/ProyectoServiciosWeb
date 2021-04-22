using V_VuelosServiciosWeb.Controllers;
using V_VuelosServiciosWeb.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web;
using System.Web.Mvc;

namespace V_VuelosServiciosWeb.Filters
{
    public class VerificaSession : ActionFilterAttribute
    {

        private USUARIO oUsuario;
        public override void OnActionExecuting(ActionExecutingContext filterContext)
        {
            try
            {
                base.OnActionExecuting(filterContext);

                oUsuario = (USUARIO)HttpContext.Current.Session["User"];
                if (oUsuario == null)
                {

                    if (filterContext.Controller is AccesoController == false)
                    {
                       //filterContext.HttpContext.Response.Redirect("~/Home/Index");
                    }
                }
            }
            catch (Exception)
            {
               //filterContext.Result = new RedirectResult("~/Admin/PaginaPrincipal");
            }

        }
    }
}
