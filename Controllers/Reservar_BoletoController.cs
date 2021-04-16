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
    public class Reservar_BoletoController : Controller
    {
        private servicioswebEntities db = new servicioswebEntities();

        // GET: Reservar_Boleto
        public async Task<ActionResult> Index()
        {
            var rESERVAR_BOLETO = db.RESERVAR_BOLETO.Include(r => r.CLIENTE);
            return View(await rESERVAR_BOLETO.ToListAsync());
        }

        // GET: Reservar_Boleto/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RESERVAR_BOLETO rESERVAR_BOLETO = await db.RESERVAR_BOLETO.FindAsync(id);
            if (rESERVAR_BOLETO == null)
            {
                return HttpNotFound();
            }
            return View(rESERVAR_BOLETO);
        }

        // GET: Reservar_Boleto/Create
        public ActionResult Create()
        {
            ViewBag.ID_CLIENTEFK = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE_CLIENTE");
            return View();
        }

        // POST: Reservar_Boleto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_RESERVAR_BOLETO,BOOKING_ID,CANTIDAD_RESERVAR_BOLETOS,TOTAL_RESERVAR_BOLETO,ID_CLIENTEFK")] RESERVAR_BOLETO rESERVAR_BOLETO)
        {
            if (ModelState.IsValid)
            {
                db.RESERVAR_BOLETO.Add(rESERVAR_BOLETO);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CLIENTEFK = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE_CLIENTE", rESERVAR_BOLETO.ID_CLIENTEFK);
            return View(rESERVAR_BOLETO);
        }

        // GET: Reservar_Boleto/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RESERVAR_BOLETO rESERVAR_BOLETO = await db.RESERVAR_BOLETO.FindAsync(id);
            if (rESERVAR_BOLETO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CLIENTEFK = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE_CLIENTE", rESERVAR_BOLETO.ID_CLIENTEFK);
            return View(rESERVAR_BOLETO);
        }

        // POST: Reservar_Boleto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_RESERVAR_BOLETO,BOOKING_ID,CANTIDAD_RESERVAR_BOLETOS,TOTAL_RESERVAR_BOLETO,ID_CLIENTEFK")] RESERVAR_BOLETO rESERVAR_BOLETO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(rESERVAR_BOLETO).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CLIENTEFK = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE_CLIENTE", rESERVAR_BOLETO.ID_CLIENTEFK);
            return View(rESERVAR_BOLETO);
        }

        // GET: Reservar_Boleto/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            RESERVAR_BOLETO rESERVAR_BOLETO = await db.RESERVAR_BOLETO.FindAsync(id);
            if (rESERVAR_BOLETO == null)
            {
                return HttpNotFound();
            }
            return View(rESERVAR_BOLETO);
        }

        // POST: Reservar_Boleto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            RESERVAR_BOLETO rESERVAR_BOLETO = await db.RESERVAR_BOLETO.FindAsync(id);
            db.RESERVAR_BOLETO.Remove(rESERVAR_BOLETO);
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
