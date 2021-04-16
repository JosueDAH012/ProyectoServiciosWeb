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
    public class Comprar_BoletoController : Controller
    {
        private servicioswebEntities db = new servicioswebEntities();

        // GET: Comprar_Boleto
        public async Task<ActionResult> Index()
        {
            var cOMPRAR_BOLETO = db.COMPRAR_BOLETO.Include(c => c.CLIENTE);
            return View(await cOMPRAR_BOLETO.ToListAsync());
        }

        // GET: Comprar_Boleto/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COMPRAR_BOLETO cOMPRAR_BOLETO = await db.COMPRAR_BOLETO.FindAsync(id);
            if (cOMPRAR_BOLETO == null)
            {
                return HttpNotFound();
            }
            return View(cOMPRAR_BOLETO);
        }

        // GET: Comprar_Boleto/Create
        public ActionResult Create()
        {
            ViewBag.ID_CLIENTEFK = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE_CLIENTE");
            return View();
        }

        // POST: Comprar_Boleto/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_BOLETO,ID_CLIENTEFK,FECHA_COMPRAR_BOLETO,PAGO_COMPRAR_BOLETO,MONTO_COMPRAR_BOLETO")] COMPRAR_BOLETO cOMPRAR_BOLETO)
        {
            if (ModelState.IsValid)
            {
                db.COMPRAR_BOLETO.Add(cOMPRAR_BOLETO);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ID_CLIENTEFK = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE_CLIENTE", cOMPRAR_BOLETO.ID_CLIENTEFK);
            return View(cOMPRAR_BOLETO);
        }

        // GET: Comprar_Boleto/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COMPRAR_BOLETO cOMPRAR_BOLETO = await db.COMPRAR_BOLETO.FindAsync(id);
            if (cOMPRAR_BOLETO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_CLIENTEFK = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE_CLIENTE", cOMPRAR_BOLETO.ID_CLIENTEFK);
            return View(cOMPRAR_BOLETO);
        }

        // POST: Comprar_Boleto/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_BOLETO,ID_CLIENTEFK,FECHA_COMPRAR_BOLETO,PAGO_COMPRAR_BOLETO,MONTO_COMPRAR_BOLETO")] COMPRAR_BOLETO cOMPRAR_BOLETO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(cOMPRAR_BOLETO).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ID_CLIENTEFK = new SelectList(db.CLIENTE, "ID_CLIENTE", "NOMBRE_CLIENTE", cOMPRAR_BOLETO.ID_CLIENTEFK);
            return View(cOMPRAR_BOLETO);
        }

        // GET: Comprar_Boleto/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            COMPRAR_BOLETO cOMPRAR_BOLETO = await db.COMPRAR_BOLETO.FindAsync(id);
            if (cOMPRAR_BOLETO == null)
            {
                return HttpNotFound();
            }
            return View(cOMPRAR_BOLETO);
        }

        // POST: Comprar_Boleto/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            COMPRAR_BOLETO cOMPRAR_BOLETO = await db.COMPRAR_BOLETO.FindAsync(id);
            db.COMPRAR_BOLETO.Remove(cOMPRAR_BOLETO);
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
