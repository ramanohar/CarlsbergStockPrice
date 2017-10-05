using CarlsbergStockPrice.Models;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
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
            new Product { Id = 1, Name = "CARL-B", Category = "Brewery", Price = 696 },
            
        };

        [Route("GetStockPrice")]
        public string GetStockPrice()
        {

            WebClient web_client = new WebClient();
            var json = web_client.DownloadString(@"https://finance.google.com/finance?q=CARL-B&output=json");
            return JsonConvert.SerializeObject(json, Formatting.Indented);

            //string jsonFormatted = JValue.Parse(json).ToString(Formatting.Indented); 
            //return json; 

        }

        
    }
}
