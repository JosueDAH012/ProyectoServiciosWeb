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
    public class PaisController : Controller
    {
        private servicioswebEntities1 db = new servicioswebEntities1();

        // GET: Pais
        public async Task<ActionResult> Index()
        {
            var pAIS = db.PAIS.Include(p => p.IMAGEN_PAIS);
            return View(await pAIS.ToListAsync());
        }

        // GET: Pais/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PAIS pAIS = await db.PAIS.FindAsync(id);
            if (pAIS == null)
            {
                return HttpNotFound();
            }
            return View(pAIS);
        }

        // GET: Pais/Create
        public ActionResult Create()
        {
            ViewBag.ID_IMAGEN_PAISFK = new SelectList(db.IMAGEN_PAIS, "ID_IMAGEN_PAIS", "ID_IMAGEN_PAIS");
            return View();
        }

        // POST: Pais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_PAIS,NOMBRE_PAIS,ID_IMAGEN_PAISFK")] PAIS pAIS)
        {
            if (ModelState.IsValid)
            {
                db.PAIS.Add(pAIS);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ID_IMAGEN_PAISFK = new SelectList(db.IMAGEN_PAIS, "ID_IMAGEN_PAIS", "ID_IMAGEN_PAIS", pAIS.ID_IMAGEN_PAISFK);
            return View(pAIS);
        }

        // GET: Pais/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PAIS pAIS = await db.PAIS.FindAsync(id);
            if (pAIS == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_IMAGEN_PAISFK = new SelectList(db.IMAGEN_PAIS, "ID_IMAGEN_PAIS", "ID_IMAGEN_PAIS", pAIS.ID_IMAGEN_PAISFK);
            return View(pAIS);
        }

        // POST: Pais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_PAIS,NOMBRE_PAIS,ID_IMAGEN_PAISFK")] PAIS pAIS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pAIS).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ID_IMAGEN_PAISFK = new SelectList(db.IMAGEN_PAIS, "ID_IMAGEN_PAIS", "ID_IMAGEN_PAIS", pAIS.ID_IMAGEN_PAISFK);
            return View(pAIS);
        }

        // GET: Pais/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            PAIS pAIS = await db.PAIS.FindAsync(id);
            if (pAIS == null)
            {
                return HttpNotFound();
            }
            return View(pAIS);
        }

        // POST: Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            PAIS pAIS = await db.PAIS.FindAsync(id);
            db.PAIS.Remove(pAIS);
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
