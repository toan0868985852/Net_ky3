using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace Movie.Models
{
    public class ProductDatabaseInitializer : DropCreateDatabaseAlways<ProductContext>
    {
        protected override void Seed(ProductContext context)
        {
            GetCategories().ForEach(c => context.Categories.Add(c));
            GetProducts().ForEach(p => context.Products.Add(p));
        }
        private static List<Category> GetCategories()
        {
            var categories = new List<Category> {
                new Category
                {
                    CategoryID = 1,
                    CategoryName = "Khoa học viễn tưởng"
                },
                new Category
                {
                    CategoryID = 2,
                    CategoryName = "Hành động"
                },
                new Category{
                    CategoryID = 3,
                    CategoryName = "Kinh dị"
                },
                new Category
                {
                    CategoryID = 4,
                    CategoryName = "Phim hài"
                },
                new Category
                {
                    CategoryID = 5,
                    CategoryName = "Phim hoạt hình"
                },
            };
            return categories;
        }
        private static List<Product> GetProducts()
        {
            var products = new List<Product>
            {
                new Product
                {
                    ProductID = 1,
                    ProductName = "Khủng long trỗi dậy",
                    Description = "This convertible car is fast! The engine is powered by a neutrino based battery (not included). Power it up and let it go!",
                    ImagePath="1.jpg",
                    link = "https://www.youtube.com/watch?v=JoUJUcodhoM",
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 2,
                    ProductName = "Siêu chiến binh",
                    Description = "There's nothing old about this toy car, except it's looks. Compatible with other old toy cars.",
                    ImagePath="2.jpg",
                    link = "https://www.youtube.com/watch?v=8npwDZd3pDY",
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 3,
                    ProductName = "Người khổng lồ TITAN",
                    Description = "Yes this car is fast, but it also floats in water.",
                    ImagePath="3.jpg",
                     link = "https://www.youtube.com/watch?v=JoUJUcodhoM",
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 4,
                    ProductName = "Hành tinh chết",
                    Description = "Use this super fast car to entertain guests.Lights and doors work!",
                    ImagePath="4.jpg",
                    link = "https://www.youtube.com/watch?v=8npwDZd3pDY",
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 5,
                    ProductName = "Cuộc chiến quái vật",
                    Description = "This old style racer can fly (with user assistance). Gravity controls flight duration." +
                    "No batteries required.",
                    ImagePath = "5.jpg",
                     link = "https://www.youtube.com/watch?v=JoUJUcodhoM",
                    CategoryID = 1
                },
                new Product
                {
                    ProductID = 6,
                    ProductName = "Thử thách sống còn",
                    Description = "Authentic airplane toy. Features realistic color and details.",
                    ImagePath="6.jpg",
                    link = "https://www.youtube.com/watch?v=8npwDZd3pDY",
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 7,
                    ProductName = "Chiến binh bất tử",
                    Description = "This fun glider is made from real balsa wood.Some assembly required.",
                    ImagePath="7.jpg",
                    link = "https://www.youtube.com/watch?v=8npwDZd3pDY",
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 8,
                    ProductName = "Vụ cướp đậm máu",
                    Description = "This paper plane is like no other paper plane.Some folding required.",
                    ImagePath = "8.jpg",
                     link = "https://www.youtube.com/watch?v=JoUJUcodhoM",
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 9,
                    ProductName = "Tay cự phách",
                    Description = "Rubber band powered plane features two wheels.",
                    ImagePath = "9.jpg",
                    link = "https://www.youtube.com/watch?v=8npwDZd3pDY",
                    CategoryID = 2
                },
                new Product
                {
                    ProductID = 10,
                    ProductName = "Mùa hè đen tối",
                    Description = "This toy truck has a real gas powered engine.Requires regular tune ups.",
                    ImagePath = "10.jpg",
                     link = "https://www.youtube.com/watch?v=JoUJUcodhoM",
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 11,
                    ProductName = "Đảo săn mồi",
                    Description = "You will have endless fun with this one quarter sized fire truck.",
                    ImagePath = "11.jpg",
                    link = "https://www.youtube.com/watch?v=8npwDZd3pDY",
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 12,
                    ProductName = "Vùng biển tử thần",
                    Description = "This fun toy truck can be used to tow other trucks that are not as big.",
                    ImagePath = "12.jpg",
                    link = "https://www.youtube.com/watch?v=8npwDZd3pDY",
                    CategoryID = 3
                },
                new Product
                {
                    ProductID = 13,
                    ProductName = "Biệt đội hài hước",
                    Description = "Is it a boat or a ship. Let this floating vehicle decide by using its artifically intelligent computer brain!",
                    ImagePath = "13.jpg",
                    link = "https://www.youtube.com/watch?v=8npwDZd3pDY",
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 14,
                    ProductName = "Đại gia chân đất",
                    Description = "Floating fun for all! This toy boat can be assembled in seconds.Floats for minutes! Some folding required.",
                    ImagePath = "14.jpg",
                     link = "https://www.youtube.com/watch?v=JoUJUcodhoM",
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 15,
                    ProductName = "Làng ế vợ",
                    Description = "Put this fun toy sail boat in the water and let it go!",
                    ImagePath = "15.jpg",
                    link = "https://www.youtube.com/watch?v=8npwDZd3pDY",
                    CategoryID = 4
                },
                new Product
                {
                    ProductID = 16,
                    ProductName = "Tom and Jerry",
                    Description = "This fun rocket will travel up to a height of 200 feet.",
                    ImagePath = "16.jpg",
                     link = "https://www.youtube.com/watch?v=JoUJUcodhoM",
                    CategoryID = 5
                }
            };
            return products;
        }
    }
}
