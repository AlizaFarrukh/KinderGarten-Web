using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using WebApplication3;

namespace WebApplication3.Controllers
{
    public class SignUpTablesController : Controller
    {
        private KindergartenEntities db = new KindergartenEntities();

        // GET: SignUpTables
        public async Task<ActionResult> Index()
        {
            return View(await db.SignUpTables.ToListAsync());
        }

        // GET: SignUpTables/Details/5
        public async Task<ActionResult> Details(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignUpTable signUpTable = await db.SignUpTables.FindAsync(id);
            if (signUpTable == null)
            {
                return HttpNotFound();
            }
            return View(signUpTable);
        }

        // GET: SignUpTables/Create
        public ActionResult SignUp()
        {
            return View();
        }

        // POST: SignUpTables/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> SignUp([Bind(Include = "UserID,Email,Password,ConfirmPassword,IsEmailVerified,ActvationCode,Type")] SignUpTable signUpTable)
        {
            if (ModelState.IsValid)
            {
                db.SignUpTables.Add(signUpTable);
                await db.SaveChangesAsync();
                
                return RedirectToAction("Index");
            }

            return View(signUpTable);
        }

        // GET: SignUpTables/Edit/5
        public async Task<ActionResult> Edit(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignUpTable signUpTable = await db.SignUpTables.FindAsync(id);
            if (signUpTable == null)
            {
                return HttpNotFound();
            }
            return View(signUpTable);
        }

        // POST: SignUpTables/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "UserID,Email,Password,ConfirmPassword,IsEmailVerified,ActvationCode,Type")] SignUpTable signUpTable)
        {
            if (ModelState.IsValid)
            {
                db.Entry(signUpTable).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            return View(signUpTable);
        }

        // GET: SignUpTables/Delete/5
        public async Task<ActionResult> Delete(string id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            SignUpTable signUpTable = await db.SignUpTables.FindAsync(id);
            if (signUpTable == null)
            {
                return HttpNotFound();
            }
            return View(signUpTable);
        }

        // POST: SignUpTables/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(string id)
        {
            SignUpTable signUpTable = await db.SignUpTables.FindAsync(id);
            db.SignUpTables.Remove(signUpTable);
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
