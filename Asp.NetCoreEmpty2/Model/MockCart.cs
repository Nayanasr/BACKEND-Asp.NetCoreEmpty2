using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreEmpty2.Model
{
    public class MockCart: ICart
    {
        private List<Cart> _cart = new List<Cart>();
        public MockCart() {
            _cart.Add(new Cart() { cart_id = 1, cart_name = "cartnatix", shopping_type = "online", no_of_items = 2, type_of_items = new string[] { "Metal", "wood", "plastic", "steel" } });
            _cart.Add(new Cart() { cart_id = 2, cart_name = "capablecart", shopping_type = "online", no_of_items = 2 }); 
                _cart.Add(new Cart() { cart_id = 3, cart_name = "luckycatalog", shopping_type = "online", no_of_items = 2});
                _cart.Add(new Cart() { cart_id = 4, cart_name = "cartnectar", shopping_type = "online", no_of_items = 2 });
            }
            //    _cart.Add(new Cart() { cart_id = 1,cart_name = "cartnatix", shopping_type = "online", no_of_items = 2, type_of_items = "metal" });
            //    _cart.Add(new Cart() { cart_id = 2,cart_name = "capablecart", shopping_type = "online", no_of_items = 2, type_of_items = "plastic" });
            //    _cart.Add(new Cart() { cart_id = 3, cart_name = "luckycatalog", shopping_type = "online", no_of_items = 2, type_of_items = "wood" });
            //    _cart.Add(new Cart() { cart_id = 4, cart_name = "cartnectar", shopping_type = "online", no_of_items = 2, type_of_items = "steel" });
            //}

            Cart ICart.GetCart(int cart_id) {
            return _cart.FirstOrDefault(e => e.cart_id == cart_id);
        }
    }
}
