using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using GarageMVC.DataAccessLayer;
using GarageMVC.Models;
using System.Diagnostics;

namespace GarageMVC.Controllers
{
    public class VehiclesController : Controller
    {
        private VehiclesContext db = new VehiclesContext();

        // GET: Vehicles
        public ActionResult Index()
        {
            return View(db.Vehicles.ToList());
        }

        //
        public ActionResult Overview(string sortOrder)
        {
            ViewBag.VehicleTypeSortParm = String.IsNullOrEmpty(sortOrder) ? "VehicleType" : "";
            ViewBag.CheckInTimeSortParm = sortOrder == "CheckInTime" ? "CheckinTime" : "";
            ViewBag.RegNrSortParm = sortOrder == "RegNr" ? "RegNr" : "";
            var vehicles = from v in db.Vehicles
                           select v;
            switch (sortOrder)
            {
                case "VehicleType":
                    vehicles = vehicles.OrderBy(v => v.VehicleType);
                    break;
                case "CheckInTime":
                    vehicles = vehicles.OrderBy(v => v.CheckInTime);
                    break;
                case "RegNr":
                    vehicles = vehicles.OrderBy(v => v.RegNr);
                    break;
                case "Color":
                    vehicles = vehicles.OrderBy(v => v.Color);
                    break;

                default:
                    vehicles = vehicles.OrderBy(v => v.VehicleType);
                    break;
            }




            return View(vehicles);
        }

        public ActionResult Search(string searchTerm = "")
        {
            var searchobj = db.Vehicles
                            .OrderBy(r => r.RegNr)
                            .Where(r => r.RegNr.Contains(searchTerm) 
                                || r.Color.Contains(searchTerm));
                                 






            return View(searchobj);



        }

        // GET: Vehicles/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // GET: Vehicles/Create
        public ActionResult Create()
        {
            return View();

        }

        // POST: Vehicles/Create
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,VehicleType,RegNr,Color,Brand,Model,NrWheels")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Vehicles.Add(vehicle);
                vehicle.CheckInTime = DateTime.Now;
                db.SaveChanges();
                return RedirectToAction("Overview");
            }

            return View(vehicle);
        }

        // GET: Vehicles/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }

        // POST: Vehicles/Edit/5
        // To protect from overposting attacks, please enable the specific properties you want to bind to, for 
        // more details see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,VehicleType,RegNr,Color,Brand,Model,NrWheels")] Vehicle vehicle)
        {
            if (ModelState.IsValid)
            {
                db.Entry(vehicle).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(vehicle);
        }

        // GET: Vehicles/Delete/5
        //kollar om id är null
        // kollar om vehicle är null

        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Vehicle vehicle = db.Vehicles.Find(id);
            if (vehicle == null)
            {
                return HttpNotFound();
            }
            return View(vehicle);
        }


        // POST: Vehicles/Delete/5

        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Vehicle vehicle = db.Vehicles.Find(id);


            db.Vehicles.Remove(vehicle);
            db.SaveChanges();


            int price;
            price = 60;
            TimeSpan totalParkingTime;
            DateTime CheckOutTime = DateTime.Now;
            totalParkingTime = CheckOutTime.Subtract(vehicle.CheckInTime);
            int totalParkHours = totalParkingTime.Hours;
            int totalParkMinutes = totalParkingTime.Minutes;
            int totalPrice = totalParkHours * price + totalParkMinutes;
            Debug.WriteLine(totalPrice);
            Console.WriteLine(totalPrice);
            ViewBag.CheckOutTime = CheckOutTime;
            ViewBag.totalPrice = totalPrice;
            ViewBag.totalParkHours = totalParkHours;
            ViewBag.totalParkMinutes = totalParkMinutes;




            return View("Receipt", vehicle);
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
