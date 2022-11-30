using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Asp.NetCoreEmpty2.Model
{
    public interface ICart
    {  
        Cart GetCart(int cart_id);
    }
}
