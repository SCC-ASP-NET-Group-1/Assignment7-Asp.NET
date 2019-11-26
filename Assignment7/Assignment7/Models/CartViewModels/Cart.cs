using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Assignment7.Models.CartViewModels
{
    public class Cart
    {
        public string UserID { get; set; }
        public List<Listing> Listings { get; set; }


    }
}
