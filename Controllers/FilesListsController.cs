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
    public class FilesListsController : Controller
    {
        private ApplicationDbContext db = new ApplicationDbContext();

        // GET: FilesLists
        public ActionResult Index()
        {
            return View(db.FilesLists.ToList());
        }

        // GET: FilesLists/ShowSearchForm
        public ActionResult ShowSearchForm()
        {
            return View();
        }

        // GET: FilesLists/ShowSearchResults
        public ActionResult ShowSearchResults(String SearchPhrase)
        {
            return View("Index", db.FilesLists.Where(j=> j.FileName.Contains(SearchPhrase)).ToList());
        }

        // GET: FilesLists/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilesList filesList = db.FilesLists.Find(id);
            if (filesList == null)
            {
                return HttpNotFound();
            }
            return View(filesList);
        }

        // GET: FilesLists/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: FilesLists/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FileName,FileDate,FileDetails")] FilesList filesList)
        {
            if (ModelState.IsValid)
            {
                db.FilesLists.Add(filesList);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(filesList);
        }

        // GET: FilesLists/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilesList filesList = db.FilesLists.Find(id);
            if (filesList == null)
            {
                return HttpNotFound();
            }
            return View(filesList);
        }

        // POST: FilesLists/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FileName,FileDate,FileDetails")] FilesList filesList)
        {
            if (ModelState.IsValid)
            {
                db.Entry(filesList).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(filesList);
        }

        // GET: FilesLists/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            FilesList filesList = db.FilesLists.Find(id);
            if (filesList == null)
            {
                return HttpNotFound();
            }
            return View(filesList);
        }

        // POST: FilesLists/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            FilesList filesList = db.FilesLists.Find(id);
            db.FilesLists.Remove(filesList);
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
