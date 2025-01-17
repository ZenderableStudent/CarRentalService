﻿namespace CarRentalService.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using CarRentalService.DAL;

    public sealed class Configuration : DbMigrationsConfiguration<CarRentalService.DAL.CarsContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
            ContextKey = "CarRentalService.DAL.CarsContext";
        }

        protected override void Seed(CarRentalService.DAL.CarsContext context)
        {
            CarsInitializer.SeedCars(context);
            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method
            //  to avoid creating duplicate seed data.
        }
    }
}
