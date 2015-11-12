using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Threading.Tasks;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Lab4.Models;

namespace Lab4.Controllers
{
    public class CourseRegistrationController : Controller
    {
        private StudentsModel db = new StudentsModel();

        // GET: CourseRegistration
        public async Task<ActionResult> Index()
        {
            var courseRegistrations = db.CourseRegistrations.Include(c => c.Course).Include(c => c.Student);
            return View(await courseRegistrations.ToListAsync());
        }

        // GET: CourseRegistration/Details/5
        public async Task<ActionResult> Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseRegistration courseRegistration = await db.CourseRegistrations.FindAsync(id);
            if (courseRegistration == null)
            {
                return HttpNotFound();
            }
            return View(courseRegistration);
        }

        // GET: CourseRegistration/Create
        public ActionResult Create()
        {
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseName");
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "FirstName");
            return View();
        }

        // POST: CourseRegistration/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Create([Bind(Include = "CourseRegistrationID,CourseID,StudentID,Grade")] CourseRegistration courseRegistration)
        {
            if (ModelState.IsValid)
            {
                db.CourseRegistrations.Add(courseRegistration);
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }

            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseName", courseRegistration.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "FirstName", courseRegistration.StudentID);
            return View(courseRegistration);
        }

        // GET: CourseRegistration/Edit/5
        public async Task<ActionResult> Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseRegistration courseRegistration = await db.CourseRegistrations.FindAsync(id);
            if (courseRegistration == null)
            {
                return HttpNotFound();
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseName", courseRegistration.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "FirstName", courseRegistration.StudentID);
            return View(courseRegistration);
        }

        // POST: CourseRegistration/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> Edit([Bind(Include = "CourseRegistrationID,CourseID,StudentID,Grade")] CourseRegistration courseRegistration)
        {
            if (ModelState.IsValid)
            {
                db.Entry(courseRegistration).State = EntityState.Modified;
                await db.SaveChangesAsync();
                return RedirectToAction("Index");
            }
            ViewBag.CourseID = new SelectList(db.Courses, "CourseID", "CourseName", courseRegistration.CourseID);
            ViewBag.StudentID = new SelectList(db.Students, "StudentID", "FirstName", courseRegistration.StudentID);
            return View(courseRegistration);
        }

        // GET: CourseRegistration/Delete/5
        public async Task<ActionResult> Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            CourseRegistration courseRegistration = await db.CourseRegistrations.FindAsync(id);
            if (courseRegistration == null)
            {
                return HttpNotFound();
            }
            return View(courseRegistration);
        }

        // POST: CourseRegistration/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<ActionResult> DeleteConfirmed(int id)
        {
            CourseRegistration courseRegistration = await db.CourseRegistrations.FindAsync(id);
            db.CourseRegistrations.Remove(courseRegistration);
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
