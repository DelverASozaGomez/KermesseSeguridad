using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using KermesseApp.Models;

namespace KermesseApp.Controllers
{
    public class tbl_bonosController : Controller
    {
        private KERMESSEEntities db = new KERMESSEEntities();

        // GET: tbl_bonos
        public ActionResult Index()
        {
            return View(db.tbl_bonos.ToList());
        }

        // GET: tbl_bonos/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_bonos tbl_bonos = db.tbl_bonos.Find(id);
            if (tbl_bonos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_bonos);
        }

        // GET: tbl_bonos/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: tbl_bonos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id_bono,nombre,valor,estado")] tbl_bonos tbl_bonos)
        {
            if (ModelState.IsValid)
            {
                db.tbl_bonos.Add(tbl_bonos);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(tbl_bonos);
        }

        // GET: tbl_bonos/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_bonos tbl_bonos = db.tbl_bonos.Find(id);
            if (tbl_bonos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_bonos);
        }

        // POST: tbl_bonos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id_bono,nombre,valor,estado")] tbl_bonos tbl_bonos)
        {
            if (ModelState.IsValid)
            {
                db.Entry(tbl_bonos).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(tbl_bonos);
        }

        // GET: tbl_bonos/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            tbl_bonos tbl_bonos = db.tbl_bonos.Find(id);
            if (tbl_bonos == null)
            {
                return HttpNotFound();
            }
            return View(tbl_bonos);
        }

        // POST: tbl_bonos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            tbl_bonos tbl_bonos = db.tbl_bonos.Find(id);
            db.tbl_bonos.Remove(tbl_bonos);
            db.SaveChanges();
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
