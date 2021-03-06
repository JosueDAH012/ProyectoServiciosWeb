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
    public class PuertaController : Controller
    {
        private servicioswebEntities2 db = new servicioswebEntities2();
        // GET: Puerta
        public async Task<ActionResult> Index()
        {
            return View(await db.PUERTA.ToListAsync());
        }

        // GET: Puerta/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PUERTA pUERTA = await db.PUERTA.FindAsync(id);
            if (pUERTA == null)
            {
                return HttpNotFound();
            }
            return View(pUERTA);
        }

        // GET: Puerta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Puerta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_PUERTA,NUMERO_PUERTA,DETALLE_PUERTA")] PUERTA pUERTA)
        {
            if (ModelState.IsValid)
            {
                db.PUERTA.Add(pUERTA);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(pUERTA);
        }

        // GET: Puerta/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PUERTA pUERTA = await db.PUERTA.FindAsync(id);
            if (pUERTA == null)
            {
                return HttpNotFound();
            }
            return View(pUERTA);
        }

        // POST: Puerta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_PUERTA,NUMERO_PUERTA,DETALLE_PUERTA")] PUERTA pUERTA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pUERTA).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(pUERTA);
        }

        // GET: Puerta/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PUERTA pUERTA = await db.PUERTA.FindAsync(id);
            if (pUERTA == null)
            {
                return HttpNotFound();
            }
            return View(pUERTA);
        }

        // POST: Puerta/Delete/5
        [System.Web.Mvc.HttpPost, System.Web.Mvc.ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            PUERTA pUERTA = await db.PUERTA.FindAsync(id);
            db.PUERTA.Remove(pUERTA);
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

    public class PuertasController : GeneralController
    {
        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetConPuerta")]
        public IEnumerable<CONSECUTIVO_PUERTA> GetConPuerta()
        {

            var con = db.CONSECUTIVO_PUERTA.ToList();

            return con;

        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("InsertConPuerta")]
        public IHttpActionResult InsertConPuerta([FromBody] CONSECUTIVO_PUERTA con)
        {
            if (ModelState.IsValid)
            {
                db.CONSECUTIVO_PUERTA.Add(con);
                db.SaveChanges();
                return Ok(con);
            }
            else
            {
                return BadRequest();
            }
        }


        [System.Web.Mvc.HttpDelete]
        [System.Web.Mvc.Route("DeleteConPuerta")]
        public IHttpActionResult EliminarPuerta(int id_con)
        {
            var con = db.CONSECUTIVO_PUERTA.Find(id_con);

            if (con != null)
            {
                db.CONSECUTIVO_PUERTA.Remove(con);
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
