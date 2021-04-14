using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace CarRentalService.Models
{
    public class Category
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Wprowadz nazwe")]
        public string Name { get; set; }
        public string Desc { get; set; }
        public ICollection<Car> Car { get; set; }
    }
}