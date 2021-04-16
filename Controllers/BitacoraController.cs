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
    public class BitacoraController : Controller
    {
        private servicioswebEntities db = new servicioswebEntities();

        // GET: Bitacora
        public async Task<ActionResult> Index()
        {
            return View(await db.BITACORA.ToListAsync());
        }

        // GET: Bitacora/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BITACORA bITACORA = await db.BITACORA.FindAsync(id);
            if (bITACORA == null)
            {
                return HttpNotFound();
            }
            return View(bITACORA);
        }

        // GET: Bitacora/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Bitacora/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_BITACORA,USUARIO_BITACORA,FECHA_BITACORA,CODIGO_BITACORA,TIPO_BITACORA,DESCRIPCION_BITACORA,DETALLE_BITACORA")] BITACORA bITACORA)
        {
            if (ModelState.IsValid)
            {
                db.BITACORA.Add(bITACORA);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(bITACORA);
        }

        // GET: Bitacora/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BITACORA bITACORA = await db.BITACORA.FindAsync(id);
            if (bITACORA == null)
            {
                return HttpNotFound();
            }
            return View(bITACORA);
        }

        // POST: Bitacora/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_BITACORA,USUARIO_BITACORA,FECHA_BITACORA,CODIGO_BITACORA,TIPO_BITACORA,DESCRIPCION_BITACORA,DETALLE_BITACORA")] BITACORA bITACORA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(bITACORA).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(bITACORA);
        }

        // GET: Bitacora/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            BITACORA bITACORA = await db.BITACORA.FindAsync(id);
            if (bITACORA == null)
            {
                return HttpNotFound();
            }
            return View(bITACORA);
        }

        // POST: Bitacora/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            BITACORA bITACORA = await db.BITACORA.FindAsync(id);
            db.BITACORA.Remove(bITACORA);
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
