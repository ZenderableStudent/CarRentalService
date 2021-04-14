using System.Data.Entity;
using CarRentalService.Models;

namespace CarRentalService.DAL
{
    public class CarsContext : DbContext
    {
        public CarsContext()
            : base("CarsContext")
        {
            Database.SetInitializer<CarsContext>(new CarsInitializer());

        }

        public DbSet<Car> Cars { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}