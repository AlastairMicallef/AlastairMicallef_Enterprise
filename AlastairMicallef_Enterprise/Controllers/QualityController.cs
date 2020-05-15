using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using AlastairMicallef_Enterprise.Models;

namespace AlastairMicallef_Enterprise.Controllers
{
    public class QualityController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: Quality
        public ActionResult Index()
        {
            return View(db.QualityModels.ToList());
        }

        // GET: Quality/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QualityModels qualityModels = db.QualityModels.Find(id);
            if (qualityModels == null)
            {
                return HttpNotFound();
            }
            return View(qualityModels);
        }

        // GET: Quality/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Quality/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Qualityame,Description")] QualityModels qualityModels)
        {
            if (ModelState.IsValid)
            {
                db.QualityModels.Add(qualityModels);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(qualityModels);
        }

        // GET: Quality/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QualityModels qualityModels = db.QualityModels.Find(id);
            if (qualityModels == null)
            {
                return HttpNotFound();
            }
            return View(qualityModels);
        }

        // POST: Quality/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Qualityame,Description")] QualityModels qualityModels)
        {
            if (ModelState.IsValid)
            {
                db.Entry(qualityModels).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(qualityModels);
        }

        // GET: Quality/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            QualityModels qualityModels = db.QualityModels.Find(id);
            if (qualityModels == null)
            {
                return HttpNotFound();
            }
            return View(qualityModels);
        }

        // POST: Quality/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            QualityModels qualityModels = db.QualityModels.Find(id);
            db.QualityModels.Remove(qualityModels);
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
