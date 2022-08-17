using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Threading.Tasks;
using System.Web.Http;
using CodeTest170822.Models;
namespace CodeTest170822.Controllers
{
    public class ProductController : ApiController
    {
        private OfferService offerService;
        public ProductController()
        {
            offerService = new OfferService();
        }

        // GET: Products
        public List< Product> GetAllProducts()
        {
            return offerService.GetAllProducts();
        }

        public List<Product> GetLowPriceProducts()
        {
            return offerService.GetAllProducts().OrderBy(x=>x.Price).Take(6).ToList();
        }

        public Product GetSecondLowPriceProducts()
        {
            return offerService.GetAllProducts().OrderBy(x => x.Price).Take(2).OrderByDescending(x=>x.Price).FirstOrDefault();
        }

        public Product PostProduct(Product prod)
        {
             offerService.AddProduct(prod);
            return prod;
        }
    }
}
