using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Net;
using System.Web;
using System.Web.Mvc;
using CarInsurance.Models;

namespace CarInsurance.Controllers
{
    public class InsureeController : Controller
    {
        private InsuranceEntities db = new InsuranceEntities();

        // GET: Insuree
        public ActionResult Index()
        {
            return View(db.Insurees.ToList());
        }

        // GET: Insuree/Details/5
        public ActionResult Details(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // GET: Insuree/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Insuree/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            //Calculate a Quote, based on information user inputs into form, that triggers loops when certain parameters are met.
            //Since you calculated age by using hard coded year values, (instead of calculating the age based off their birth year and the current year),
            //this program will have to be updated every year on New Years day to maintain the correct calculations. This will be costly to maintain. 
            //However the assignment is successful.
            if (ModelState.IsValid)
            {
                insuree.Quote = 50; // Start with a base of $50 a month

                if(insuree.DateOfBirth.Year >= 2003) // If the user is 18 and under, add $100 to monthly total
                {
                    insuree.Quote += 100;
                }

                else if(insuree.DateOfBirth.Year <= 2002 && insuree.DateOfBirth.Year >= 1996) // If the user is between 19 and 25, add $50 to the monthly total
                {
                    insuree.Quote += 50;
                }

                else if (insuree.DateOfBirth.Year < 1996) // If the user is over 25, add $25 to the monthly total.
                {
                    insuree.Quote += 25;
                }

                if(insuree.CarYear < 2000) // If the car's year is before 2000, add $25 to the monthly total.
                {
                    insuree.Quote += 25;
                }

                else if(insuree.CarYear > 2015) // If the car's year is after 2015, add $25 to the monthly total.
                {
                    insuree.Quote += 25;
                }

                if (insuree.CarMake.Equals("Porsche")) // If the car's Make is a Porsche, add $25 to the price.
                {
                    insuree.Quote += 25;

                    if (insuree.CarModel.Equals("911 Carrera")) // If the car's Make is a Porsche and its model is a 911 Carrera, add an additional $25 to the price.
                    {
                        insuree.Quote += 25;
                    }
                }


                insuree.Quote += insuree.SpeedingTickets * 10; // Add $10 to the monthly total for every speeding ticket the user has.

                if (insuree.DUI == true) // If the user has ever had a DUI, add 25% to the total.
                {
                    insuree.Quote += insuree.Quote * 0.25m;
                }

                if (insuree.CoverageType == true) // If it's full coverage, add 50% to the total.
                {
                    insuree.Quote += insuree.Quote * 0.50m;
                }

                db.Insurees.Add(insuree);
                db.SaveChanges();
                return RedirectToAction("Index");
            }

            return View(insuree);
        }

        // GET: Insuree/Edit/5
        public ActionResult Edit(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to, for 
        // more details see https://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit([Bind(Include = "Id,FirstName,LastName,EmailAddress,DateOfBirth,CarYear,CarMake,CarModel,DUI,SpeedingTickets,CoverageType,Quote")] Insuree insuree)
        {
            if (ModelState.IsValid)
            {
                db.Entry(insuree).State = EntityState.Modified;
                db.SaveChanges();
                return RedirectToAction("Index");
            }
            return View(insuree);
        }

        // GET: Insuree/Delete/5
        public ActionResult Delete(int? id)
        {
            if (id == null)
            {
                return new HttpStatusCodeResult(HttpStatusCode.BadRequest);
            }
            Insuree insuree = db.Insurees.Find(id);
            if (insuree == null)
            {
                return HttpNotFound();
            }
            return View(insuree);
        }

        // POST: Insuree/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public ActionResult DeleteConfirmed(int id)
        {
            Insuree insuree = db.Insurees.Find(id);
            db.Insurees.Remove(insuree);
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
