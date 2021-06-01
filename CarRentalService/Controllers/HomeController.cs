using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using CarRentalService.DAL;
using CarRentalService.Models;

namespace CarRentalService.Controllers
{
    public class HomeController : Controller
    {
        CarsContext db = new CarsContext();

        // GET: Home
        public ActionResult Index()
        {
            //zebranie kategorii do listy i wrzucenie ich widoku:
            //var categories = db.Categories.ToList();

            return View();
        }
        //Dodanie metody zwracajacej widok strony: 
        public ActionResult StronyStatyczne(string nazwa)
        {
            return View(nazwa);
        }
    }
}