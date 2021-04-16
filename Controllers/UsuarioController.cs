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
    public class UsuarioController : Controller
    {
        private servicioswebEntities db = new servicioswebEntities();

        // GET: Usuario
        public async Task<ActionResult> Index()
        {
            var uSUARIO = db.USUARIO.Include(u => u.ROL);
            return View(await uSUARIO.ToListAsync());
        }

        // GET: Usuario/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = await db.USUARIO.FindAsync(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // GET: Usuario/Create
        public ActionResult Create()
        {
            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL");
            return View();
        }

        // POST: Usuario/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_USUARIO,NOMBRE_USUARIO,CLAVE_USUARIO,EMAIL_USUARIO,PREGUNTA_SEGURIDAD_USUARIO,RESPUESTA_SEGURIDAD_USUARIO,ID_ROLFK")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                db.USUARIO.Add(uSUARIO);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL", uSUARIO.ID_ROLFK);
            return View(uSUARIO);
        }

        // GET: Usuario/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = await db.USUARIO.FindAsync(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL", uSUARIO.ID_ROLFK);
            return View(uSUARIO);
        }

        // POST: Usuario/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_USUARIO,NOMBRE_USUARIO,CLAVE_USUARIO,EMAIL_USUARIO,PREGUNTA_SEGURIDAD_USUARIO,RESPUESTA_SEGURIDAD_USUARIO,ID_ROLFK")] USUARIO uSUARIO)
        {
            if (ModelState.IsValid)
            {
                db.Entry(uSUARIO).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.ID_ROLFK = new SelectList(db.ROL, "ID_ROL", "TIPO_ROL", uSUARIO.ID_ROLFK);
            return View(uSUARIO);
        }

        // GET: Usuario/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            USUARIO uSUARIO = await db.USUARIO.FindAsync(id);
            if (uSUARIO == null)
            {
                return HttpNotFound();
            }
            return View(uSUARIO);
        }

        // POST: Usuario/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            USUARIO uSUARIO = await db.USUARIO.FindAsync(id);
            db.USUARIO.Remove(uSUARIO);
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
