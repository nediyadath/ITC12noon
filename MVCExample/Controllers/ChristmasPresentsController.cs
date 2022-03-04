using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MVCExample.Models;

namespace MVCExample.Controllers
{
    public class ChristmasPresentsController : Controller
    {
        private ChristmasContext db = new ChristmasContext();

        // GET: ChristmasPresents
        public ActionResult Index()
        {
            return View(db.cPresent.ToList());
        }

        // GET: ChristmasPresents/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChristmasPresent christmasPresent = db.cPresent.Find(id);
            if (christmasPresent == null)
            {
                return HttpNotFound();
            }
            return View(christmasPresent);
        }

        // GET: ChristmasPresents/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ChristmasPresents/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "id,nameOfKid,present")] ChristmasPresent christmasPresent)
        {
            if (ModelState.IsValid)
            {
                db.cPresent.Add(christmasPresent);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(christmasPresent);
        }

        // GET: ChristmasPresents/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChristmasPresent christmasPresent = db.cPresent.Find(id);
            if (christmasPresent == null)
            {
                return HttpNotFound();
            }
            return View(christmasPresent);
        }

        // POST: ChristmasPresents/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "id,nameOfKid,present")] ChristmasPresent christmasPresent)
        {
            if (ModelState.IsValid)
            {
                db.Entry(christmasPresent).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(christmasPresent);
        }

        // GET: ChristmasPresents/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            ChristmasPresent christmasPresent = db.cPresent.Find(id);
            if (christmasPresent == null)
            {
                return HttpNotFound();
            }
            return View(christmasPresent);
        }

        // POST: ChristmasPresents/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            ChristmasPresent christmasPresent = db.cPresent.Find(id);
            db.cPresent.Remove(christmasPresent);
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
