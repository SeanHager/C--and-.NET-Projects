using CarInsurance.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace CarInsurance.Controllers
{
    public class AdminController : Controller
    {
        public ActionResult Admin()
        {
            using(InsuranceEntities db = new InsuranceEntities())
            {
                var insuree = db.Insurees;
                var insureeList = new List<Insuree>();

                foreach(var i in insuree)
                {
                    var insPerson = new Insuree();
                    insPerson.FirstName = i.FirstName;
                    insPerson.LastName = i.LastName;
                    insPerson.EmailAddress = i.EmailAddress;
                    insPerson.Quote = i.Quote;

                    insureeList.Add(insPerson);
                }
                return View(insureeList);
            }
        }
    }
}