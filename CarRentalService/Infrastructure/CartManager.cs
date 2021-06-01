using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using CarRentalService.DAL;

namespace CarRentalService.Infrastructure
{
    public class CartManager
    {
        CarsContext db;
        ISessionManager session;

        public CartManager(CarsContext db, ISessionManager session)
        {
            this.db = db;
            this.session = session;
        }
        public List<CartItem> GetItems()
        {
            List<CartItem> items;
            //Jesli sesja jest pusta to inicjalizujemy listę nowym obiektem
            if (session.Get<List<CartItem>>(Consts.CartSessionKey)==null)
            {
                items = new List<CartItem>();
            }
            //pobieramy sesje i zapisujemy do listy
            else
            {
                items = session.Get<List<CartItem>>(Consts.CartSessionKey);
            }
            return items;
        }
        public void AddToCart(int carId)
        {
            var cart = GetItems();
            var thisCar = cart.Find(c => c.Car.CarID == carId);

            //jeśli został już dodany to zwiększamy jego ilość
            if(thisCar != null)
            {
                thisCar.Quantity++;
            }
            else
            {
                var newCartItem = db.Cars.Where(c => c.CarID == carId).SingleOrDefault();
                //sprawdzamy czy pobrzny item nie jest pusty
                if(newCartItem != null)
                {
                    var CartItem = new CartItem
                    {
                        Car = newCartItem,
                        Quantity = 1,
                        Value = newCartItem.Price
                    };

                    cart.Add(CartItem);
                    session.Set(Consts.CartSessionKey, cart);
                }
            }
        }
        public int RemoveFromCart(int carId)
        {
            var cart = GetItems();
            var thisCar = cart.Find(c => c.Car.CarID == carId);

            if (thisCar != null)
            {
                if(thisCar.Quantity > 1)
                {
                    thisCar.Quantity--;
                    return thisCar.Quantity;
                }
                else
                {
                    cart.Remove(thisCar);
                }
            }
            return 0;
        }
        public decimal GetCartValue()
        {
            var cart = GetItems();
            return cart.Sum(i => (i.Quantity * i.Value));
        }
        public int GetCartQuantity()
        {
            var cart = GetItems();
            return cart.Sum(i => i.Quantity);
        }
    }
}