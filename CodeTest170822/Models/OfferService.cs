using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace CodeTest170822.Models
{
    public class OfferService
    {

        public OfferService()
        {
            CreateProducts();
        }


        private List<Product> Inventory { get; set; }

        private void CreateProducts()
        {
            Inventory = new List<Product>();
            Inventory.Add(new Product("P1", 1000, "P1 desc"));
            Inventory.Add(new Product("P2", 200, "P2 desc"));
            Inventory.Add(new Product("P3", 400, "P3 desc"));
            Inventory.Add(new Product("P4", 700, "P4 desc"));
            Inventory.Add(new Product("P5", 600, "P5 desc"));
            Inventory.Add(new Product("P6", 800, "P6 desc"));
        }
        public void AddProduct(Product prod)
        {
            if (Inventory == null)
                Inventory = new List<Product>();
            Inventory.Add(prod);

        }

        public List<Product> GetAllProducts()
        {
            return Inventory;
        }

        public List<Offer> GetTodaysOffers()
        {
            var offers = new List<Offer>();
            offers.Add(new Offer("ComboPackage1", new List<Product>() { Inventory[0], Inventory[1], Inventory[2] }));
            offers.Add(new Offer("ComboPackage1", new List<Product>() { Inventory[2], Inventory[4], Inventory[5] }));
            offers.Add(new Offer("ComboPackage1", new List<Product>() { Inventory[1], Inventory[2], Inventory[3] }));

            return offers;
        }


    }
}