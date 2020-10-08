using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ContosoCraft.Website.Models;
using ContosoCraft.Website.Services;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ContosoCraft.Website.Pages
{
    public class IndexModel : PageModel
    {
        private readonly ILogger<IndexModel> _logger;
        public JsonFileProductsService ProductsService;
        public IEnumerable<Product> Products { get; private set; }

        public IndexModel(
            ILogger<IndexModel> logger,
            JsonFileProductsService productService)
        {
            _logger = logger;
            ProductsService = productService;
        }

        public void OnGet()
        {
            Products = ProductsService.GetProducts();
        }
    }
}
