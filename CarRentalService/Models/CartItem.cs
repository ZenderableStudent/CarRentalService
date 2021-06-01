using CarRentalService.Models;

namespace CarRentalService.Infrastructure
{
    public class CartItem
    {
        public Car Car { get; set; }
        public int Quantity { get; set; }
        public decimal Value { get; set; }
    }
}