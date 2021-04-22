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
    public class PuertaController : Controller
    {
        private servicioswebEntities1 db = new servicioswebEntities1();

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
        [HttpPost]
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
        [HttpPost]
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
        [HttpPost, ActionName("Delete")]
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
}
