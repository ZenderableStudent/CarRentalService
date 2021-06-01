using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data.Entity;
using System.Linq;
using System.Web;
using CarRentalService.Models;
using CarRentalService.Migrations;
using System.Data.Entity.Migrations;

namespace CarRentalService.DAL
{
    public class CarsInitializer : MigrateDatabaseToLatestVersion<CarsContext, CarRentalService.Migrations.Configuration>
    {
        public static void SeedCars(CarsContext context)
        {
            var categories = new List<Category>()
            {
                new Category
                {
                    CategoryID = 1,
                    Name = "Van",
                    Desc = "Samochod rodzinny"
                },
                new Category
                {
                    CategoryID = 2,
                    Name = "Sedan",
                    Desc = "Sportowy wyglad"
                },
                new Category
                {
                    CategoryID = 3,
                    Name = "Kombi",
                    Desc = "Dużo przestrzeni w bagażniku"
                },
                new Category
                {
                    CategoryID = 4,
                    Name = "Hatchback",
                    Desc = "Krótszy tył"
                }
            };

            foreach (var category in categories)
            {
                context.Categories.AddOrUpdate(category);
            }

            context.SaveChanges();

            var cars = new List<Car>()
            { 
                new Car
                {
                    Mark = "Ford",
                    Model = "Focus",
                    CarRegistration = "CB00001",
                    CategoryID = 3,
                    AddDate = new DateTime(2007,3,14),
                    PosterName = "fordFocus.jpg",
                    Price = 100
                },
                new Car
                {
                    Mark = "Honda",
                    Model = "Civic",
                    CarRegistration = "CB00002",
                    CategoryID = 2,
                    AddDate = new DateTime(2010,6,1),
                    PosterName = "hondaCivic.jpg",
                    Price = 130
                },
                new Car
                {
                    Mark = "Nissan",
                    Model = "Skyline",
                    CarRegistration = "CB00003",
                    CategoryID = 2,
                    AddDate = new DateTime(2015,3,9),
                    PosterName = "nissanSkyline.jpg",
                    Price = 300
                },
                new Car
                {
                    Mark = "Nissan",
                    Model = "Juke",
                    CarRegistration = "CB00004",
                    CategoryID = 1,
                    AddDate = new DateTime(2018,3,9),
                    PosterName = "nissanJuke.jpg",
                    Price = 50
                },
                new Car
                {
                    Mark = "Kia",
                    Model = "Ceed",
                    CarRegistration = "CB00005",
                    CategoryID = 4,
                    AddDate = new DateTime(2021,4,29),
                    PosterName = "kiaCeed.jpg",
                    Price = 215
                },
                new Car
                {
                    Mark = "Alfa Romeo",
                    Model = "Giulietta",
                    CarRegistration = "CB00006",
                    CategoryID = 4,
                    AddDate = new DateTime(2020,4,29),
                    PosterName = "alfaromeoGiulietta.jpg",
                    Price = 100
                },
                new Car
                {
                    Mark = "Audi",
                    Model = "A3",
                    CarRegistration = "CB00007",
                    CategoryID = 3,
                    AddDate = new DateTime(2019,4,29),
                    PosterName = "audiA3.jpg",
                    Price = 120
                },
                new Car
                {
                    Mark = "Audi",
                    Model = "A6",
                    CarRegistration = "CB00008",
                    CategoryID = 3,
                    AddDate = new DateTime(2021,4,20),
                    PosterName = "audiA6.jpg",
                    Price = 95
                },
                new Car
                {
                    Mark = "Ford",
                    Model = "Mondeo",
                    CarRegistration = "CB00009",
                    CategoryID = 2,
                    AddDate = new DateTime(2021,3,20),
                    PosterName = "fordMondeo.jpg",
                    Price = 13
                },
                new Car
                {
                    Mark = "Mazda",
                    Model = "3",
                    CarRegistration = "CB00010",
                    CategoryID = 2,
                    AddDate = new DateTime(2021,4,20),
                    PosterName = "mazda3.jpg",
                    Price = 100
                },
                new Car
                {
                    Mark = "Saab",
                    Model = "9-3x",
                    CarRegistration = "CB00011",
                    CategoryID = 3,
                    AddDate = new DateTime(2021,4,20),
                    PosterName = "Saab 9-3x.jpg",
                    Price = 78
                }
            };
            foreach (var car in cars)
            {
                //add-Migration 'nazwa'   dodanie migracji
                //update-Database-TargetMigration:podajemuNazweMigracji
                //update-Database odświeżenie bazy danych

                //Zmiana przeglądania bazy, nie po CarID tylko przez CarRegistration
                context.Cars.AddOrUpdate(c=>c.CarRegistration,car);
            }

            context.SaveChanges();

        }
    }
}