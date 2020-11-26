using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using eshop.Models;

namespace eshop.Models.ViewModels
{
    public class ProductListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PageInfo PageInfo { get; set; }

        public string CurrentCategory { get; set; }
    }
}
