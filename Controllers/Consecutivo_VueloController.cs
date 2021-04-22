using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using V_VuelosServiciosWeb.Models;

namespace V_VuelosServiciosWeb.Controllers
{
    public class Consecutivo_VueloController : Controller
    {
        private servicioswebEntities1 db = new servicioswebEntities1();

        // GET: Consecutivo_Vuelo
        public async Task<ActionResult> Index()
        {
            return View(await db.CONSECUTIVO_VUELO.ToListAsync());
        }

        // GET: Consecutivo_Vuelo/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_VUELO cONSECUTIVO_VUELO = await db.CONSECUTIVO_VUELO.FindAsync(id);
            if (cONSECUTIVO_VUELO == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_VUELO);
        }

        // GET: Consecutivo_Vuelo/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consecutivo_Vuelo/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_CONSECUTIVO_VUELO,CONSECUTIVO_VUELO1,PREFIJO_VUELO,RANGO_INICIAL_VUELO,RANGO_FINAL_VUELO")] CONSECUTIVO_VUELO cONSECUTIVO_VUELO)
        {
            if (ModelState.IsValid)
            {
                db.CONSECUTIVO_VUELO.Add(cONSECUTIVO_VUELO);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cONSECUTIVO_VUELO);
        }

        // GET: Consecutivo_Vuelo/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_VUELO cONSECUTIVO_VUELO = await db.CONSECUTIVO_VUELO.FindAsync(id);
            if (cONSECUTIVO_VUELO == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_VUELO);
        }

        // POST: Consecutivo_Vuelo/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_CONSECUTIVO_VUELO,CONSECUTIVO_VUELO1,PREFIJO_VUELO,RANGO_INICIAL_VUELO,RANGO_FINAL_VUELO")] CONSECUTIVO_VUELO cONSECUTIVO_VUELO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONSECUTIVO_VUELO).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cONSECUTIVO_VUELO);
        }

        // GET: Consecutivo_Vuelo/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_VUELO cONSECUTIVO_VUELO = await db.CONSECUTIVO_VUELO.FindAsync(id);
            if (cONSECUTIVO_VUELO == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_VUELO);
        }

        // POST: Consecutivo_Vuelo/Delete/5
        [System.Web.Mvc.HttpPost, System.Web.Mvc.ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CONSECUTIVO_VUELO cONSECUTIVO_VUELO = await db.CONSECUTIVO_VUELO.FindAsync(id);
            db.CONSECUTIVO_VUELO.Remove(cONSECUTIVO_VUELO);
            await db.SaveChangesAsync();
            return RedirectToAction("Index");
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

    public class VuelosController : GeneralController
    {
        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetConVuelo")]
        public IEnumerable<CONSECUTIVO_VUELO> GetConVuelo()
        {

            var con = db.CONSECUTIVO_VUELO.ToList();

            return con;

        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("InsertConVuelo")]
        public IHttpActionResult InsertConVuelo([FromBody] CONSECUTIVO_VUELO con)
        {
            if (ModelState.IsValid)
            {
                db.CONSECUTIVO_VUELO.Add(con);
                db.SaveChanges();
                return Ok(con);
            }
            else
            {
                return BadRequest();
            }
        }


        [System.Web.Mvc.HttpDelete]
        [System.Web.Mvc.Route("DeleteConVuelo")]
        public IHttpActionResult EliminarVuelo(int id_con)
        {
            var con = db.CONSECUTIVO_VUELO.Find(id_con);

            if (con != null)
            {
                db.CONSECUTIVO_VUELO.Remove(con);
                db.SaveChanges();
                return Ok(con);
            }
            else
            {
                return NotFound();
            }
        }
    }
}
