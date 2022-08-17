using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest170822.Models
{
    public class Product
    {
        public Product(string productName, decimal price, string desc)
        {
            ProductName = productName;
            Price = price;
            Description = desc;
        }

        public string ProductName { get; set; }
        public decimal Price { get; set; }

        public string Description { get; set; }
    }
}