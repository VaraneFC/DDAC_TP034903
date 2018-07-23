using DDAC_TP034903.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using DDAC_TP034903.Controllers;
using System.Net;

namespace DDAC_TP034903.Controllers
{
    public class BookingManagementController : System.Web.Mvc.Controller
    {
        private Maersk_LineContext db = new Maersk_LineContext();
        // GET: BookingManagement
        public ActionResult BookingManagement()
        {
            return View(db.Bookings.ToList());
        }

        //GET: Bookings Details
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        //get: bookings/create
        public ActionResult Create()
        {
            return View();
        }

        //post:bookings/create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "BookingID, ShipID, Price, Date, Time, Departure, Destination")] Booking booking)
        {
            if (ModelState.IsValid)
            {
                db.Bookings.Add(booking);
                db.SaveChanges();
                return RedirectToAction("BookingManagement");
            }
            return View(booking);
        }

        //get: Bookings/Edit
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        //post:Bookings/Edit
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "BookingID, ShipID, ContainerID, Price, Date, Time, Departure, Destination")] Booking booking)
        {
            if(ModelState.IsValid)
            {
                db.Entry(booking).State = System.Data.EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("BookingManagement");
            }
            return View(booking);
        }
        // GET: Bookings/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Booking booking = db.Bookings.Find(id);
            if (booking == null)
            {
                return HttpNotFound();
            }
            return View(booking);
        }

        // POST: Bookings/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Booking booking = db.Bookings.Find(id);
            db.Bookings.Remove(booking);
            db.SaveChanges();
            return RedirectToAction("BookingManagement");
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
