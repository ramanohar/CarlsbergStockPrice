using CarlsbergStockPrice.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace CarlsbergStockPrice.Controllers
{
    public class StocksController : ApiController
    {
        Product[] products = new Product[]
        {
            new Product { Id = 1, Name = "Carlsberg", Category = "Beer", Price = 200 },
            
        };

        [Route("GetStockPrice")]
        public IEnumerable<Product> GetStockPrice()
        {
            return products;
        }

        
    }
}
