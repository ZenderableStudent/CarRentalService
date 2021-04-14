using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRentalService.DAL;
using CarRentalService.Models;

namespace CarRentalService.Controllers
{
    public class HomeController : Controller
    {
        private CarsContext _db = new CarsContext();
        // GET: Home
        public ActionResult Index()
        {
            foreach (var a in _db.Categories)
            {
                Debug.WriteLine(a.Name);
            }
            return View();
        }
    }
}