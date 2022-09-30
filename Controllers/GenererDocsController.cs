using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using MUAT.Models;

namespace MUAT.Controllers
{
    [Authorize]
    public class GenererDocsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: GenererDocs
        public ActionResult Index()
        {
            return View(db.GenererDocs.ToList());
        }

        // GET: GenererDocs/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GenererDoc genererDoc = db.GenererDocs.Find(id);
            if (genererDoc == null)
            {
                return HttpNotFound();
            }
            return View(genererDoc);
        }

        // GET: GenererDocs/Create
        public ActionResult Create()
        {
            return View();
        }
        
        // GET: GenererDocs/CreateCPS
        public ActionResult CreateCPS()
        {
            return View();
        }
        
        // GET: GenererDocs/CreateRC
        public ActionResult CreateRC()
        {
            return View();
        }

        // GET: GenererDocs/CreateAvisFr
        public ActionResult CreateAvisFr()
        {
            return View();
        }
        
        // GET: GenererDocs/CreateAvisAr
        public ActionResult CreateAvisAr()
        {
            return View();
        }

        // POST: GenererDocs/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,Document")] GenererDoc genererDoc)
        {
            if (ModelState.IsValid)
            {
                db.GenererDocs.Add(genererDoc);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(genererDoc);
        }

        // GET: GenererDocs/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GenererDoc genererDoc = db.GenererDocs.Find(id);
            if (genererDoc == null)
            {
                return HttpNotFound();
            }
            return View(genererDoc);
        }

        // POST: GenererDocs/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,Document")] GenererDoc genererDoc)
        {
            if (ModelState.IsValid)
            {
                db.Entry(genererDoc).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(genererDoc);
        }

        // GET: GenererDocs/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            GenererDoc genererDoc = db.GenererDocs.Find(id);
            if (genererDoc == null)
            {
                return HttpNotFound();
            }
            return View(genererDoc);
        }

        // POST: GenererDocs/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            GenererDoc genererDoc = db.GenererDocs.Find(id);
            db.GenererDocs.Remove(genererDoc);
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
