using System.Collections.Generic;

namespace AhihiStore.Models.ViewModels
{ 
    public class ProductsListViewModel
    {
        public IEnumerable<Product> Products { get; set; }
        public PagingInfo PagingInfo { get; set; }
    }
}
