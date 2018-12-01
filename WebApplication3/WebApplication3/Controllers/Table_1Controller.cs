using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3;

namespace WebApplication3.Controllers
{
    public class Table_1Controller : Controller
    {
        private LoginEntities db = new LoginEntities();

        // GET: Table_1
        public ActionResult Index()
        {
            return View(db.Table_1.ToList());
        }

        // GET: Table_1/Details/5
        public ActionResult Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_1 table_1 = db.Table_1.Find(id);
            if (table_1 == null)
            {
                return HttpNotFound();
            }
            return View(table_1);
        }

        // GET: Table_1/Create
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: Table_1/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult SignUp([Bind(Include = "UserID,Email,Password,ConfirmPassword")] Table_1 table_1)
        {
            if (ModelState.IsValid)
            {
                db.Table_1.Add(table_1);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(table_1);
        }

        // GET: Table_1/Edit/5
        public ActionResult Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_1 table_1 = db.Table_1.Find(id);
            if (table_1 == null)
            {
                return HttpNotFound();
            }
            return View(table_1);
        }

        // POST: Table_1/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "UserID,Email,Password,ConfirmPassword")] Table_1 table_1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table_1).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(table_1);
        }

        // GET: Table_1/Delete/5
        public ActionResult Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table_1 table_1 = db.Table_1.Find(id);
            if (table_1 == null)
            {
                return HttpNotFound();
            }
            return View(table_1);
        }

        // POST: Table_1/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            Table_1 table_1 = db.Table_1.Find(id);
            db.Table_1.Remove(table_1);
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
