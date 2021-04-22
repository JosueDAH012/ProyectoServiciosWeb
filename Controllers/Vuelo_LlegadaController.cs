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
    public class Vuelo_LlegadaController : Controller
    {
        private servicioswebEntities1 db = new servicioswebEntities1();

        // GET: Vuelo_Llegada
        public async Task<ActionResult> Index()
        {
            var vUELO_LLEGADA = db.VUELO_LLEGADA.Include(v => v.AEROLINEA).Include(v => v.PUERTA);
            return View(await vUELO_LLEGADA.ToListAsync());
        }

        // GET: Vuelo_Llegada/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VUELO_LLEGADA vUELO_LLEGADA = await db.VUELO_LLEGADA.FindAsync(id);
            if (vUELO_LLEGADA == null)
            {
                return HttpNotFound();
            }
            return View(vUELO_LLEGADA);
        }

        // GET: Vuelo_Llegada/Create
        public ActionResult Create()
        {
            ViewBag.ID_AEROLINEAFK = new SelectList(db.AEROLINEA, "ID_AEROLINEA", "NOMBRE_AEROLINEA");
            ViewBag.ID_PUERTAFK = new SelectList(db.PUERTA, "ID_PUERTA", "DETALLE_PUERTA");
            return View();
        }

        // POST: Vuelo_Llegada/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_VUELO_LLEGADA,ID_AEROLINEAFK,PROCEDENCIA_VUELO_LLEGADA,FECHA_VUELO_LLEGADA,HORA_VUELO_LLEGADA,ID_PUERTAFK")] VUELO_LLEGADA vUELO_LLEGADA)
        {
            if (ModelState.IsValid)
            {
                db.VUELO_LLEGADA.Add(vUELO_LLEGADA);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ID_AEROLINEAFK = new SelectList(db.AEROLINEA, "ID_AEROLINEA", "NOMBRE_AEROLINEA", vUELO_LLEGADA.ID_AEROLINEAFK);
            ViewBag.ID_PUERTAFK = new SelectList(db.PUERTA, "ID_PUERTA", "DETALLE_PUERTA", vUELO_LLEGADA.ID_PUERTAFK);
            return View(vUELO_LLEGADA);
        }

        // GET: Vuelo_Llegada/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VUELO_LLEGADA vUELO_LLEGADA = await db.VUELO_LLEGADA.FindAsync(id);
            if (vUELO_LLEGADA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_AEROLINEAFK = new SelectList(db.AEROLINEA, "ID_AEROLINEA", "NOMBRE_AEROLINEA", vUELO_LLEGADA.ID_AEROLINEAFK);
            ViewBag.ID_PUERTAFK = new SelectList(db.PUERTA, "ID_PUERTA", "DETALLE_PUERTA", vUELO_LLEGADA.ID_PUERTAFK);
            return View(vUELO_LLEGADA);
        }

        // POST: Vuelo_Llegada/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_VUELO_LLEGADA,ID_AEROLINEAFK,PROCEDENCIA_VUELO_LLEGADA,FECHA_VUELO_LLEGADA,HORA_VUELO_LLEGADA,ID_PUERTAFK")] VUELO_LLEGADA vUELO_LLEGADA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vUELO_LLEGADA).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ID_AEROLINEAFK = new SelectList(db.AEROLINEA, "ID_AEROLINEA", "NOMBRE_AEROLINEA", vUELO_LLEGADA.ID_AEROLINEAFK);
            ViewBag.ID_PUERTAFK = new SelectList(db.PUERTA, "ID_PUERTA", "DETALLE_PUERTA", vUELO_LLEGADA.ID_PUERTAFK);
            return View(vUELO_LLEGADA);
        }

        // GET: Vuelo_Llegada/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VUELO_LLEGADA vUELO_LLEGADA = await db.VUELO_LLEGADA.FindAsync(id);
            if (vUELO_LLEGADA == null)
            {
                return HttpNotFound();
            }
            return View(vUELO_LLEGADA);
        }

        // POST: Vuelo_Llegada/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            VUELO_LLEGADA vUELO_LLEGADA = await db.VUELO_LLEGADA.FindAsync(id);
            db.VUELO_LLEGADA.Remove(vUELO_LLEGADA);
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
