using lab5_Product.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace lab5_Product.Controllers
{
    public class ProductController : ApiController
    {
        private readonly ProductEntities _context = new ProductEntities();

        [HttpPost]
        [Authorize]
        [Route("api/Product/Create")]
        public IHttpActionResult Create(ProductModel productModel)
        {
            var product = new Table_DB_Product()
            {
                Name = productModel.Name,
                Price = productModel.Price
            };
            _context.Table_DB_Product.Add(product);
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpPost]
        [Authorize]
        [Route("api/Product/GetAll")]
        public IHttpActionResult GetAll(ProductModel productModel)
        {
            var products = _context.Table_DB_Product.ToList();
            return Ok(products);
        }

        [HttpPost]
        [Authorize]
        [Route("api/Product/Modify")]
        public IHttpActionResult Modify(ProductModel productModel)
        {
            var product = new Table_DB_Product()
            {
                Name = productModel.Name,
                Id = productModel.Id,
                Price = productModel.Price
            };
            _context.Entry(product).State = System.Data.Entity.EntityState.Modified;
            _context.SaveChanges();
            return Ok("Success");
        }

        [HttpPost]
        [Authorize]
        [Route("api/Product/Delete/{id}")]
        public IHttpActionResult Delete(int id)
        {
            var product = _context.Table_DB_Product.SingleOrDefault(e => e.Id == id);
            _context.Table_DB_Product.Remove(product);
            _context.SaveChanges();
            return Ok("Success");
        }
    }
}
