using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest170822.Models
{
    public class Offer
    {
        public Offer(string offername, List<Product> products)
        {
            Products = new List<Product>(); 
            OfferName = offername;
            Products = products;
        }
        public string OfferName { get; set; }
        public List<Product> Products { get; set; }
    }
}