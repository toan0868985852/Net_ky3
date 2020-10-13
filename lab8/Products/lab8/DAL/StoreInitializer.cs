using lab8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Data.Entity;
using System.Web;


namespace lab8.DAL
{
    public class StoreInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<Store>
    {
        protected override void Seed(Store context)
        {
            
            var categorys = new List<Category>
            {
                new Category{CategoryName="Apple",},
                new Category{CategoryName="Samsung",},
                new Category{CategoryName="Laptop",},
            };

            categorys.ForEach(s => context.Categorys.Add(s));
            context.SaveChanges();

            var products = new List<Product>
            {
                new Product{CategoryID=1, ProductName="Iphone X",ProductImage="https://cdn1.viettelstore.vn/images/Product/ProductImage/medium/2132584444.jpeg",},
                new Product{CategoryID=1, ProductName="Iphone Xr",ProductImage="https://cdn.tgdd.vn/Products/Images/42/190325/iphone-xr-white-600x600.jpg",},
                new Product{CategoryID=2, ProductName="Samsung s10",ProductImage="https://didongviet.vn/pub/media/catalog/product//s/a/samsung-galaxy-s10-plus-12gb-1tb-didongviet_1_3_1.jpg",},
                new Product{CategoryID=2, ProductName="Samsung not10",ProductImage="https://didongviet.vn/pub/media/catalog/product//s/a/samsung-galaxy-note-10-cu-didongviet.jpg",},
                new Product{CategoryID=3, ProductName="Laptop gaming",ProductImage="https://surfacecu.com.vn/wp-content/uploads/2020/05/surface-laptop-3-a1-1.jpg",},
                new Product{CategoryID=3, ProductName="Laptop Dell",ProductImage="https://hanoicomputercdn.com/media/product/47380_dell_latitude_3400__1_.jpg",},
            };

            products.ForEach(s => context.Products.Add(s));
            context.SaveChanges();
        }
    }
}