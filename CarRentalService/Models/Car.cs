using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CarRentalService.Models
{
    public class Car
    {
        public int CarId { get; set; }
        [Required(ErrorMessage = "Wprowadz marke")]
        public string Mark { get; set; }
        [Required(ErrorMessage = "Wprowadz model")]
        public string Model { get; set; }
        [StringLength(100)]
        public string Desc { get; set; }
        public decimal Price { get; set; }
        [Column(TypeName = "DateTime2")]
        public DateTime AddDate { get; set; }
        public int CategoryId { get; set; }
        public virtual Category Category { get; set; }

    }
}