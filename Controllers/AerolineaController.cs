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
    public class AerolineaController : Controller
    {
        private servicioswebEntities db = new servicioswebEntities();

        // GET: Aerolinea
        public async Task<ActionResult> Index()
        {
            var aEROLINEA = db.AEROLINEA.Include(a => a.IMAGEN_AEROLINEA);
            return View(await aEROLINEA.ToListAsync());
        }

        // GET: Aerolinea/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AEROLINEA aEROLINEA = await db.AEROLINEA.FindAsync(id);
            if (aEROLINEA == null)
            {
                return HttpNotFound();
            }
            return View(aEROLINEA);
        }

        // GET: Aerolinea/Create
        public ActionResult Create()
        {
            ViewBag.ID_IMAGEN_AEROLINEAFK = new SelectList(db.IMAGEN_AEROLINEA, "ID_IMAGEN_AEROLINEA", "ID_IMAGEN_AEROLINEA");
            return View();
        }

        // POST: Aerolinea/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_AEROLINEA,NOMBRE_AEROLINEA,ID_IMAGEN_AEROLINEAFK")] AEROLINEA aEROLINEA)
        {
            if (ModelState.IsValid)
            {
                db.AEROLINEA.Add(aEROLINEA);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ID_IMAGEN_AEROLINEAFK = new SelectList(db.IMAGEN_AEROLINEA, "ID_IMAGEN_AEROLINEA", "ID_IMAGEN_AEROLINEA", aEROLINEA.ID_IMAGEN_AEROLINEAFK);
            return View(aEROLINEA);
        }

        // GET: Aerolinea/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AEROLINEA aEROLINEA = await db.AEROLINEA.FindAsync(id);
            if (aEROLINEA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_IMAGEN_AEROLINEAFK = new SelectList(db.IMAGEN_AEROLINEA, "ID_IMAGEN_AEROLINEA", "ID_IMAGEN_AEROLINEA", aEROLINEA.ID_IMAGEN_AEROLINEAFK);
            return View(aEROLINEA);
        }

        // POST: Aerolinea/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_AEROLINEA,NOMBRE_AEROLINEA,ID_IMAGEN_AEROLINEAFK")] AEROLINEA aEROLINEA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(aEROLINEA).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ID_IMAGEN_AEROLINEAFK = new SelectList(db.IMAGEN_AEROLINEA, "ID_IMAGEN_AEROLINEA", "ID_IMAGEN_AEROLINEA", aEROLINEA.ID_IMAGEN_AEROLINEAFK);
            return View(aEROLINEA);
        }

        // GET: Aerolinea/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            AEROLINEA aEROLINEA = await db.AEROLINEA.FindAsync(id);
            if (aEROLINEA == null)
            {
                return HttpNotFound();
            }
            return View(aEROLINEA);
        }

        // POST: Aerolinea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            AEROLINEA aEROLINEA = await db.AEROLINEA.FindAsync(id);
            db.AEROLINEA.Remove(aEROLINEA);
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
