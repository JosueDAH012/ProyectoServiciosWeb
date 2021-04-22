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
    public class Consecutivo_AerolineaController : Controller
    {
        private servicioswebEntities1 db = new servicioswebEntities1();

        // GET: Consecutivo_Aerolinea
        public async Task<ActionResult> Index()
        {
            return View(await db.CONSECUTIVO_AEROLINEA.ToListAsync());
        }

        // GET: Consecutivo_Aerolinea/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_AEROLINEA cONSECUTIVO_AEROLINEA = await db.CONSECUTIVO_AEROLINEA.FindAsync(id);
            if (cONSECUTIVO_AEROLINEA == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_AEROLINEA);
        }

        // GET: Consecutivo_Aerolinea/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consecutivo_Aerolinea/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_CONSECUTIVO_AEROLINEA,CONSECUTIVO_AEROLINEA1,PREFIJO_AEROLINEA,RANGO_INICIAL_AEROLINEA,RANGO_FINAL_AEROLINEA")] CONSECUTIVO_AEROLINEA cONSECUTIVO_AEROLINEA)
        {
            if (ModelState.IsValid)
            {
                db.CONSECUTIVO_AEROLINEA.Add(cONSECUTIVO_AEROLINEA);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cONSECUTIVO_AEROLINEA);
        }

        // GET: Consecutivo_Aerolinea/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_AEROLINEA cONSECUTIVO_AEROLINEA = await db.CONSECUTIVO_AEROLINEA.FindAsync(id);
            if (cONSECUTIVO_AEROLINEA == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_AEROLINEA);
        }

        // POST: Consecutivo_Aerolinea/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_CONSECUTIVO_AEROLINEA,CONSECUTIVO_AEROLINEA1,PREFIJO_AEROLINEA,RANGO_INICIAL_AEROLINEA,RANGO_FINAL_AEROLINEA")] CONSECUTIVO_AEROLINEA cONSECUTIVO_AEROLINEA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONSECUTIVO_AEROLINEA).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cONSECUTIVO_AEROLINEA);
        }

        // GET: Consecutivo_Aerolinea/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_AEROLINEA cONSECUTIVO_AEROLINEA = await db.CONSECUTIVO_AEROLINEA.FindAsync(id);
            if (cONSECUTIVO_AEROLINEA == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_AEROLINEA);
        }

        // POST: Consecutivo_Aerolinea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CONSECUTIVO_AEROLINEA cONSECUTIVO_AEROLINEA = await db.CONSECUTIVO_AEROLINEA.FindAsync(id);
            db.CONSECUTIVO_AEROLINEA.Remove(cONSECUTIVO_AEROLINEA);
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
