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
    public class Consecutivo_VueloController : Controller
    {
        private servicioswebEntities db = new servicioswebEntities();

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
        [HttpPost]
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
        [HttpPost]
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
        [HttpPost, ActionName("Delete")]
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
}
