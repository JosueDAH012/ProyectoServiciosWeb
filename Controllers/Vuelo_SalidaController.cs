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
    public class Vuelo_SalidaController : Controller
    {
        private servicioswebEntities db = new servicioswebEntities();

        // GET: Vuelo_Salida
        public async Task<ActionResult> Index()
        {
            var vUELO_SALIDA = db.VUELO_SALIDA.Include(v => v.AEROLINEA).Include(v => v.PUERTA);
            return View(await vUELO_SALIDA.ToListAsync());
        }

        // GET: Vuelo_Salida/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VUELO_SALIDA vUELO_SALIDA = await db.VUELO_SALIDA.FindAsync(id);
            if (vUELO_SALIDA == null)
            {
                return HttpNotFound();
            }
            return View(vUELO_SALIDA);
        }

        // GET: Vuelo_Salida/Create
        public ActionResult Create()
        {
            ViewBag.ID_AEROLINEAFK = new SelectList(db.AEROLINEA, "ID_AEROLINEA", "NOMBRE_AEROLINEA");
            ViewBag.ID_PUERTAFK = new SelectList(db.PUERTA, "ID_PUERTA", "DETALLE_PUERTA");
            return View();
        }

        // POST: Vuelo_Salida/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_VUELO_SALIDA,ID_AEROLINEAFK,DESTINO_VUELO_SALIDA,FECHA_VUELO_SALIDA,HORA_VUELO_SALIDA,ID_PUERTAFK")] VUELO_SALIDA vUELO_SALIDA)
        {
            if (ModelState.IsValid)
            {
                db.VUELO_SALIDA.Add(vUELO_SALIDA);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ID_AEROLINEAFK = new SelectList(db.AEROLINEA, "ID_AEROLINEA", "NOMBRE_AEROLINEA", vUELO_SALIDA.ID_AEROLINEAFK);
            ViewBag.ID_PUERTAFK = new SelectList(db.PUERTA, "ID_PUERTA", "DETALLE_PUERTA", vUELO_SALIDA.ID_PUERTAFK);
            return View(vUELO_SALIDA);
        }

        // GET: Vuelo_Salida/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VUELO_SALIDA vUELO_SALIDA = await db.VUELO_SALIDA.FindAsync(id);
            if (vUELO_SALIDA == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_AEROLINEAFK = new SelectList(db.AEROLINEA, "ID_AEROLINEA", "NOMBRE_AEROLINEA", vUELO_SALIDA.ID_AEROLINEAFK);
            ViewBag.ID_PUERTAFK = new SelectList(db.PUERTA, "ID_PUERTA", "DETALLE_PUERTA", vUELO_SALIDA.ID_PUERTAFK);
            return View(vUELO_SALIDA);
        }

        // POST: Vuelo_Salida/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_VUELO_SALIDA,ID_AEROLINEAFK,DESTINO_VUELO_SALIDA,FECHA_VUELO_SALIDA,HORA_VUELO_SALIDA,ID_PUERTAFK")] VUELO_SALIDA vUELO_SALIDA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vUELO_SALIDA).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ID_AEROLINEAFK = new SelectList(db.AEROLINEA, "ID_AEROLINEA", "NOMBRE_AEROLINEA", vUELO_SALIDA.ID_AEROLINEAFK);
            ViewBag.ID_PUERTAFK = new SelectList(db.PUERTA, "ID_PUERTA", "DETALLE_PUERTA", vUELO_SALIDA.ID_PUERTAFK);
            return View(vUELO_SALIDA);
        }

        // GET: Vuelo_Salida/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            VUELO_SALIDA vUELO_SALIDA = await db.VUELO_SALIDA.FindAsync(id);
            if (vUELO_SALIDA == null)
            {
                return HttpNotFound();
            }
            return View(vUELO_SALIDA);
        }

        // POST: Vuelo_Salida/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            VUELO_SALIDA vUELO_SALIDA = await db.VUELO_SALIDA.FindAsync(id);
            db.VUELO_SALIDA.Remove(vUELO_SALIDA);
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
