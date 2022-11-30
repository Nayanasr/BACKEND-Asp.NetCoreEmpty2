using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreEmpty2.Model
{
    public class Cart
    {
        public int cart_id { get; set; } 
        public string cart_name { get; set; }
        public string shopping_type { get; set; }
        public int no_of_items { get; set; }
        //public string type_of_items { get; set; }

        public string[] type_of_items { get; set; }
    }
}
