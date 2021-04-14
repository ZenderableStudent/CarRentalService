using System.Collections.Generic;
using System.Data.Entity;
using CarRentalService.Models;

namespace CarRentalService.DAL
{
    public class CarsInitializer : DropCreateDatabaseAlways<CarsContext>
    {
        protected override void Seed(CarsContext context)
        {
            var categories = new List<Category>
            {
                new Category
                {
                    CategoryId = 1,
                    Name = "Van",
                    Desc = "Samochod rodzinny"
                },
                new Category
                {
                    CategoryId = 2,
                    Name = "Sedan",
                    Desc = "Samochod wyglad"
                },
                new Category
                {
                    CategoryId = 3,
                    Name = "Kombi",
                    Desc = "Duzo przestrzeni w bagazniku"
                },
                new Category
                {
                    CategoryId = 4,
                    Name = "Hatchback",
                    Desc = "Krotszy tyl"
                }
            };

            context.Categories.AddRange(categories);


            var cars = new List<Car>
            {
                new Car
                {
                    CarId = 1,
                    Mark = "Ford",
                    Model = "Focus",
                    CategoryId = 3,
                },
                new Car
                {
                    CarId = 2,
                    Mark = "Honda",
                    Model = "Civic",
                    CategoryId = 2,
                }
            };


            context.Cars.AddRange(cars);
            context.SaveChanges();

            base.Seed(context);
        }

    }
}