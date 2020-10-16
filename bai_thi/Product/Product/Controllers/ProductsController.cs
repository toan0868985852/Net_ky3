using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Product.Models;
using Product.Services;

namespace Product.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        public ProductsController(ProductServices productService)
        {
            ProductService = productService;
        }

        public ProductServices ProductService { get; }

        [HttpGet]
        public IEnumerable<Product.Models.Product> Get()
        {
            return ProductService.GetProducts();
        }
    }
}