using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Http;
using System.Web.Mvc;
using V_VuelosServiciosWeb.Models;

namespace V_VuelosServiciosWeb.Controllers
{
    public class BitacoraController : Controller
    {
        private servicioswebEntities2 db = new servicioswebEntities2();

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
        [System.Web.Mvc.HttpPost]
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
        [System.Web.Mvc.HttpPost]
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
        [System.Web.Mvc.HttpPost, System.Web.Mvc.ActionName("Delete")]
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

    public class BitacorasController : GeneralController
    {
        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetBitacora")]
        public IEnumerable<BITACORA> GetBitacota()
        {
            var bitacora = db.BITACORA.ToList();
            return bitacora;
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetBitacoraID")]
        public IEnumerable<BITACORA> GetBitacotaID(int ID_BITACORA)
        {
            var bitacora = db.BITACORA.Where(x => x.ID_BITACORA == ID_BITACORA).ToList();

            return bitacora;
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("InsertBitacora")]
        public IHttpActionResult InsertBitacora([FromBody] BITACORA bitacora)
        {
            if (ModelState.IsValid)
            {
                db.BITACORA.Add(bitacora);
                db.SaveChanges();
                return Ok(bitacora);
            }
            else
            {
                return BadRequest();
            }
        }

    }
}
