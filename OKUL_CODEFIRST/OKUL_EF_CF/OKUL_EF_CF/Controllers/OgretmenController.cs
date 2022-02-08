﻿using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using OKUL_EF_CF.Models;

namespace OKUL_EF_CF.Controllers
{
    public class OgretmenController : Controller
    {
        private Ogretmen _Ogretmen { get; set; }
        public Ogretmen Ogretmen {
            get
            {
                if (this._Ogretmen == null)
                    this._Ogretmen = new Ogretmen();
                return this._Ogretmen;
            }
            set
            {
                this._Ogretmen = value;
            }
        }
        private OkulContext db = new OkulContext();

        // GET: Ogretmen
        public ActionResult Index()
        {
            return View(db.Ogretmenler.ToList());
        }

        // GET: Ogretmen/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogretmen ogretmen = db.Ogretmenler.Find(id);
            if (ogretmen == null)
            {
                return HttpNotFound();
            }
            return View(ogretmen);
        }

        // GET: Ogretmen/Create
        public ActionResult Create()
        {
            this.Ogretmen.ID = -1;
            return View(this.Ogretmen);
        }

        // POST: Ogretmen/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ID,Maas,Alan,FullName,Email,Password,Phone")] Ogretmen ogretmen)
        {
            if (ModelState.IsValid)
            {
                db.Ogretmenler.Add(ogretmen);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(ogretmen);
        }

        // GET: Ogretmen/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogretmen ogretmen = db.Ogretmenler.Find(id);
            if (ogretmen == null)
            {
                return HttpNotFound();
            }
            return View(ogretmen);
        }

        // POST: Ogretmen/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ID,Maas,Alan,FullName,Email,Password,Phone")] Ogretmen ogretmen)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ogretmen).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(ogretmen);
        }

        // GET: Ogretmen/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ogretmen ogretmen = db.Ogretmenler.Find(id);
            if (ogretmen == null)
            {
                return HttpNotFound();
            }
            return View(ogretmen);
        }

        // POST: Ogretmen/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ogretmen ogretmen = db.Ogretmenler.Find(id);
            db.Ogretmenler.Remove(ogretmen);
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
