
using System.Collections.Generic;


namespace DrinkStores.Models.ViewModels
{
    public class ProductsListViewModel
    {
        public IEnumerable<Drink> Drinks { get; set; }
        public PagingInfo PagingInfo { get; set; }
        //thông tin về việc phân loại sản phẩm
        public string CurrentCategory { get; set; }
    }
}
