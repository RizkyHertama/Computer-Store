using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using Computer_Store.Models;

namespace Computer_Store.Controllers
{
    public class PembayaranController : Controller
    {
        private CompStoreEntities db = new CompStoreEntities();

        // GET: Pembayaran
        public ActionResult Index()
        {
            return View(db.Pembayarans.ToList());
        }

        // GET: Pembayaran/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pembayaran pembayaran = db.Pembayarans.Find(id);
            if (pembayaran == null)
            {
                return HttpNotFound();
            }
            return View(pembayaran);
        }

        // GET: Pembayaran/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Pembayaran/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "IDPembayaran,JenisPembayaran")] Pembayaran pembayaran)
        {
            if (ModelState.IsValid)
            {
                db.Pembayarans.Add(pembayaran);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(pembayaran);
        }

        // GET: Pembayaran/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pembayaran pembayaran = db.Pembayarans.Find(id);
            if (pembayaran == null)
            {
                return HttpNotFound();
            }
            return View(pembayaran);
        }

        // POST: Pembayaran/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "IDPembayaran,JenisPembayaran")] Pembayaran pembayaran)
        {
            if (ModelState.IsValid)
            {
                db.Entry(pembayaran).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(pembayaran);
        }

        // GET: Pembayaran/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Pembayaran pembayaran = db.Pembayarans.Find(id);
            if (pembayaran == null)
            {
                return HttpNotFound();
            }
            return View(pembayaran);
        }

        // POST: Pembayaran/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Pembayaran pembayaran = db.Pembayarans.Find(id);
            db.Pembayarans.Remove(pembayaran);
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
