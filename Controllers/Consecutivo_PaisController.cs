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
    public class Consecutivo_PaisController : Controller
    {
        private servicioswebEntities1 db = new servicioswebEntities1();

        // GET: Consecutivo_Pais
        public async Task<ActionResult> Index()
        {
            return View(await db.CONSECUTIVO_PAIS.ToListAsync());
        }

        // GET: Consecutivo_Pais/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_PAIS cONSECUTIVO_PAIS = await db.CONSECUTIVO_PAIS.FindAsync(id);
            if (cONSECUTIVO_PAIS == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_PAIS);
        }

        // GET: Consecutivo_Pais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Consecutivo_Pais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_CONSECUTIVO_PAIS,CONSECUTIVO_PAIS1,PREFIJO_PAIS,RANGO_INICIAL_PAIS,RANGO_FINAL_PAIS")] CONSECUTIVO_PAIS cONSECUTIVO_PAIS)
        {
            if (ModelState.IsValid)
            {
                db.CONSECUTIVO_PAIS.Add(cONSECUTIVO_PAIS);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(cONSECUTIVO_PAIS);
        }

        // GET: Consecutivo_Pais/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_PAIS cONSECUTIVO_PAIS = await db.CONSECUTIVO_PAIS.FindAsync(id);
            if (cONSECUTIVO_PAIS == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_PAIS);
        }

        // POST: Consecutivo_Pais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_CONSECUTIVO_PAIS,CONSECUTIVO_PAIS1,PREFIJO_PAIS,RANGO_INICIAL_PAIS,RANGO_FINAL_PAIS")] CONSECUTIVO_PAIS cONSECUTIVO_PAIS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cONSECUTIVO_PAIS).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(cONSECUTIVO_PAIS);
        }

        // GET: Consecutivo_Pais/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CONSECUTIVO_PAIS cONSECUTIVO_PAIS = await db.CONSECUTIVO_PAIS.FindAsync(id);
            if (cONSECUTIVO_PAIS == null)
            {
                return HttpNotFound();
            }
            return View(cONSECUTIVO_PAIS);
        }

        // POST: Consecutivo_Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CONSECUTIVO_PAIS cONSECUTIVO_PAIS = await db.CONSECUTIVO_PAIS.FindAsync(id);
            db.CONSECUTIVO_PAIS.Remove(cONSECUTIVO_PAIS);
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
