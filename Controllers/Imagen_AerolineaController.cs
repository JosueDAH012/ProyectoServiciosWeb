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
    public class Imagen_AerolineaController : Controller
    {
        private servicioswebEntities2 db = new servicioswebEntities2();

        // GET: Imagen_Aerolinea
        public async Task<ActionResult> Index()
        {
            return View(await db.IMAGEN_AEROLINEA.ToListAsync());
        }

        // GET: Imagen_Aerolinea/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMAGEN_AEROLINEA iMAGEN_AEROLINEA = await db.IMAGEN_AEROLINEA.FindAsync(id);
            if (iMAGEN_AEROLINEA == null)
            {
                return HttpNotFound();
            }
            return View(iMAGEN_AEROLINEA);
        }

        // GET: Imagen_Aerolinea/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Imagen_Aerolinea/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_IMAGEN_AEROLINEA,IMAGEN_AEROLINEA1")] IMAGEN_AEROLINEA iMAGEN_AEROLINEA)
        {
            if (ModelState.IsValid)
            {
                db.IMAGEN_AEROLINEA.Add(iMAGEN_AEROLINEA);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(iMAGEN_AEROLINEA);
        }

        // GET: Imagen_Aerolinea/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMAGEN_AEROLINEA iMAGEN_AEROLINEA = await db.IMAGEN_AEROLINEA.FindAsync(id);
            if (iMAGEN_AEROLINEA == null)
            {
                return HttpNotFound();
            }
            return View(iMAGEN_AEROLINEA);
        }

        // POST: Imagen_Aerolinea/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_IMAGEN_AEROLINEA,IMAGEN_AEROLINEA1")] IMAGEN_AEROLINEA iMAGEN_AEROLINEA)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iMAGEN_AEROLINEA).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(iMAGEN_AEROLINEA);
        }

        // GET: Imagen_Aerolinea/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMAGEN_AEROLINEA iMAGEN_AEROLINEA = await db.IMAGEN_AEROLINEA.FindAsync(id);
            if (iMAGEN_AEROLINEA == null)
            {
                return HttpNotFound();
            }
            return View(iMAGEN_AEROLINEA);
        }

        // POST: Imagen_Aerolinea/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            IMAGEN_AEROLINEA iMAGEN_AEROLINEA = await db.IMAGEN_AEROLINEA.FindAsync(id);
            db.IMAGEN_AEROLINEA.Remove(iMAGEN_AEROLINEA);
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
