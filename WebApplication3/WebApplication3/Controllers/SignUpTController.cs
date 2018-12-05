﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3.Models;

namespace WebApplication3.Controllers
{
    public class SignUpTController : Controller
    {
        private LoginEntities10 db = new LoginEntities10();

        // GET: LoginT
        public async Task<ActionResult> Index()
        {
            return View(await db.Table1.ToListAsync());
        }

        // GET: LoginT/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table1 table1 = await db.Table1.FindAsync(id);
            if (table1 == null)
            {
                return HttpNotFound();
            }
            return View(table1);
        }

        // GET: LoginT/Create
        public ActionResult TeacherSignUp()
        {
            return View();
        }

        // POST: LoginT/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> TeacherSignUp([Bind(Include = "UserID,Email,Password,ConfirmPassword,IsEmailVerified,ActivationCode")] Table1 table1)
        {
            if (ModelState.IsValid)
            {
                db.Table1.Add(table1);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            return View(table1);
        }

        // GET: LoginT/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table1 table1 = await db.Table1.FindAsync(id);
            if (table1 == null)
            {
                return HttpNotFound();
            }
            return View(table1);
        }

        // POST: LoginT/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UserID,Email,Password,ConfirmPassword,IsEmailVerified,ActivationCode")] Table1 table1)
        {
            if (ModelState.IsValid)
            {
                db.Entry(table1).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(table1);
        }

        // GET: LoginT/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Table1 table1 = await db.Table1.FindAsync(id);
            if (table1 == null)
            {
                return HttpNotFound();
            }
            return View(table1);
        }

        // POST: LoginT/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            Table1 table1 = await db.Table1.FindAsync(id);
            db.Table1.Remove(table1);
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
