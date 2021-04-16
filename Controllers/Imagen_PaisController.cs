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
    public class Imagen_PaisController : Controller
    {
        private servicioswebEntities db = new servicioswebEntities();

        // GET: Imagen_Pais
        public async Task<ActionResult> Index()
        {
            return View(await db.IMAGEN_PAIS.ToListAsync());
        }

        // GET: Imagen_Pais/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMAGEN_PAIS iMAGEN_PAIS = await db.IMAGEN_PAIS.FindAsync(id);
            if (iMAGEN_PAIS == null)
            {
                return HttpNotFound();
            }
            return View(iMAGEN_PAIS);
        }

        // GET: Imagen_Pais/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Imagen_Pais/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_IMAGEN_PAIS,IMAGEN_PAIS1")] IMAGEN_PAIS iMAGEN_PAIS)
        {
            if (ModelState.IsValid)
            {
                db.IMAGEN_PAIS.Add(iMAGEN_PAIS);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(iMAGEN_PAIS);
        }

        // GET: Imagen_Pais/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMAGEN_PAIS iMAGEN_PAIS = await db.IMAGEN_PAIS.FindAsync(id);
            if (iMAGEN_PAIS == null)
            {
                return HttpNotFound();
            }
            return View(iMAGEN_PAIS);
        }

        // POST: Imagen_Pais/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_IMAGEN_PAIS,IMAGEN_PAIS1")] IMAGEN_PAIS iMAGEN_PAIS)
        {
            if (ModelState.IsValid)
            {
                db.Entry(iMAGEN_PAIS).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(iMAGEN_PAIS);
        }

        // GET: Imagen_Pais/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            IMAGEN_PAIS iMAGEN_PAIS = await db.IMAGEN_PAIS.FindAsync(id);
            if (iMAGEN_PAIS == null)
            {
                return HttpNotFound();
            }
            return View(iMAGEN_PAIS);
        }

        // POST: Imagen_Pais/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            IMAGEN_PAIS iMAGEN_PAIS = await db.IMAGEN_PAIS.FindAsync(id);
            db.IMAGEN_PAIS.Remove(iMAGEN_PAIS);
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
