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
    public class ErrorController : Controller
    {
        private servicioswebEntities2 db = new servicioswebEntities2();

        // GET: Error
        public async Task<ActionResult> Index()
        {
            return View(await db.ERROR.ToListAsync());
        }

        // GET: Error/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ERROR eRROR = await db.ERROR.FindAsync(id);
            if (eRROR == null)
            {
                return HttpNotFound();
            }
            return View(eRROR);
        }

        // GET: Error/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Error/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "ID_ERROR,FECHA_ERROR,MENSAJE_ERROR")] ERROR eRROR)
        {
            if (ModelState.IsValid)
            {
                db.ERROR.Add(eRROR);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(eRROR);
        }

        // GET: Error/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ERROR eRROR = await db.ERROR.FindAsync(id);
            if (eRROR == null)
            {
                return HttpNotFound();
            }
            return View(eRROR);
        }

        // POST: Error/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [System.Web.Mvc.HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "ID_ERROR,FECHA_ERROR,MENSAJE_ERROR")] ERROR eRROR)
        {
            if (ModelState.IsValid)
            {
                db.Entry(eRROR).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(eRROR);
        }

        // GET: Error/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ERROR eRROR = await db.ERROR.FindAsync(id);
            if (eRROR == null)
            {
                return HttpNotFound();
            }
            return View(eRROR);
        }

        // POST: Error/Delete/5
        [System.Web.Mvc.HttpPost, System.Web.Mvc.ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            ERROR eRROR = await db.ERROR.FindAsync(id);
            db.ERROR.Remove(eRROR);
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

    public class ErrorsController : GeneralController
    {
        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetError")]
        public IEnumerable<ERROR> GetError()
        {
            var error = db.ERROR.ToList();

            return error;
        }

        [System.Web.Mvc.HttpGet]
        [System.Web.Mvc.Route("GetErrorID")]
        public IEnumerable<ERROR> GetErrorID(int ID_ERROR)
        {
            var error = db.ERROR.Where(x => x.ID_ERROR == ID_ERROR).ToList();

            return error;
        }

        [System.Web.Mvc.HttpPost]
        [System.Web.Mvc.Route("InsertError")]
        public IHttpActionResult InsertError([FromBody] ERROR error)
        {
            if (ModelState.IsValid)
            {
                db.ERROR.Add(error);
                db.SaveChanges();
                return Ok(error);
            }
            else
            {
                return BadRequest();
            }
        }
    }
}
