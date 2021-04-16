using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using V_VuelosServiciosWeb.Models;

namespace V_VuelosServiciosWeb.Controllers
{
    public class Consecutivo_PuertaController : Controller
    {
        private servicioswebEntities db = new servicioswebEntities();

        // GET: Consecutivo_Puerta
        public async Task<ActionResult> Index()
        {
            return View(await db.CONSECUTIVO_PUERTA.ToListAsync());
        }

        // GET: Consecutivo_Puerta/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_PUERTA cONSECUTIVO_PUERTA = await db.CONSECUTIVO_PUERTA.FindAsync(id);
            if (cONSECUTIVO_PUERTA == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_PUERTA);
        }

        // GET: Consecutivo_Puerta/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consecutivo_Puerta/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_CONSECUTIVO_PUERTA,CONSECUTIVO_PUERTA1,PREFIJO_PUERTA,RANGO_INICIAL_PUERTA,RANGO_FINAL_PUERTA")] CONSECUTIVO_PUERTA cONSECUTIVO_PUERTA)
        {
            if (ModelState.IsValid)
            {
                db.CONSECUTIVO_PUERTA.Add(cONSECUTIVO_PUERTA);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cONSECUTIVO_PUERTA);
        }

        // GET: Consecutivo_Puerta/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_PUERTA cONSECUTIVO_PUERTA = await db.CONSECUTIVO_PUERTA.FindAsync(id);
            if (cONSECUTIVO_PUERTA == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_PUERTA);
        }

        // POST: Consecutivo_Puerta/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_CONSECUTIVO_PUERTA,CONSECUTIVO_PUERTA1,PREFIJO_PUERTA,RANGO_INICIAL_PUERTA,RANGO_FINAL_PUERTA")] CONSECUTIVO_PUERTA cONSECUTIVO_PUERTA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONSECUTIVO_PUERTA).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cONSECUTIVO_PUERTA);
        }

        // GET: Consecutivo_Puerta/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_PUERTA cONSECUTIVO_PUERTA = await db.CONSECUTIVO_PUERTA.FindAsync(id);
            if (cONSECUTIVO_PUERTA == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_PUERTA);
        }

        // POST: Consecutivo_Puerta/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CONSECUTIVO_PUERTA cONSECUTIVO_PUERTA = await db.CONSECUTIVO_PUERTA.FindAsync(id);
            db.CONSECUTIVO_PUERTA.Remove(cONSECUTIVO_PUERTA);
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
}
