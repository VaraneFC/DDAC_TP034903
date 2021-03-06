﻿using DDAC_TP034903.Models;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;

namespace DDACAssignment.Controllers
{
    public class ShipmentManagementController : Controller
    {
        private Maersk_LineContext db = new Maersk_LineContext();

        // GET: Ships
        public ActionResult ShippingManagement()
        {
            return View(db.Ships.ToList());
        }

        // GET: Ships/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ship ships = db.Ships.Find(id);
            if (ships == null)
            {
                return HttpNotFound();
            }
            return View(ships);
        }

        // GET: Ships/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Ships/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "ShipCode,ShipName,ShipDescription,NumberOfContainersCarried")] Ship ships)
        {
            if (ModelState.IsValid)
            {
                db.Ships.Add(ships);
                db.SaveChanges();
                return RedirectToAction("ShippingManagement");
            }

            return View(ships);
        }

        // GET: Ships/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ship ships = db.Ships.Find(id);
            if (ships == null)
            {
                return HttpNotFound();
            }
            return View(ships);
        }

        // POST: Ships/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "ShipCode,ShipName,ShipDescription,NumberOfContainersCarried")] Ship ships)
        {
            if (ModelState.IsValid)
            {
                db.Entry(ships).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("ShippingManagement");
            }
            return View(ships);
        }

        // GET: Ships/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Ship ships = db.Ships.Find(id);
            if (ships == null)
            {
                return HttpNotFound();
            }
            return View(ships);
        }

        // POST: Ships/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Ship ships = db.Ships.Find(id);
            db.Ships.Remove(ships);
            db.SaveChanges();
            return RedirectToAction("ShippingManagement");
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