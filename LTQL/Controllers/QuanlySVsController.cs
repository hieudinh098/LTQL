using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using LTQL.Models;

namespace LTQL.Controllers
{
    public class QuanlySVsController : Controller
    {
        private LapTrinhQuanLyDBcontext db = new LapTrinhQuanLyDBcontext();

        // GET: QuanlySVs
        public ActionResult Index()
        {
            var list = db.QuanlySVs.ToList();
            return View(list);
        }

        // GET: QuanlySVs/Details/5
        public ActionResult Details(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            var quanLy = db.QuanlySVs.Find(id);
            if (quanLy == null)
            {
                return HttpNotFound();
            }
            return View(quanLy);
        }

        // GET: QuanlySVs/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: QuanlySVs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "StudentID,StudentName,Address")] QuanlySV quanLy)
        {
            if (ModelState.IsValid)
            {
                db.Students.Add(quanLy);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(quanLy);
        }

        // GET: QuanlySVs/Edit/5
        public ActionResult Edit(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanlySV quanLy = db.QuanlySVs.Find(id);
            if (quanLy == null)
            {
                return HttpNotFound();
            }
            return View(quanLy);
        }

        // POST: QuanlySVs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "StudentID,StudentName,Address")] QuanlySV quanLy)
        {
            if (ModelState.IsValid)
            {
                db.Entry(quanLy).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(quanLy);
        }

        // GET: QuanlySVs/Delete/5
        public ActionResult Delete(string id)
        {
            if (String.IsNullOrEmpty(id))
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QuanlySV quanLy = db.QuanlySVs.Find(id);
            if (quanLy == null)
            {
                return HttpNotFound();
            }
            return View(quanLy);
        }

        // POST: QuanlySVs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(string id)
        {
            QuanlySV quanlySV = db.QuanlySVs.Find(id);
            db.Students.Remove(quanlySV);
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
