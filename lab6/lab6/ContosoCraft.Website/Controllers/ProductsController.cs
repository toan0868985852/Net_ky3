using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCraft.Website.Models;
using ContosoCraft.Website.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ContosoCraft.Website.Controllers
{
    [Route("[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(JsonFileProductsService productsService)
        {
            this.ProductsService = productsService;
        }

        public JsonFileProductsService ProductsService { get;}

        [HttpGet]
        public IEnumerable<Product> Get()
        {
            return ProductsService.GetProducts();
        }

        //[HttpPatch] "[Frombody]"
        [Route("Rate")]
        [HttpGet]
        public ActionResult Get(
            [FromQuery] string ProductId, 
            [FromQuery] int Rating)
        {
            ProductsService.AddRating(ProductId, Rating);
            return Ok();
        }
    }
}