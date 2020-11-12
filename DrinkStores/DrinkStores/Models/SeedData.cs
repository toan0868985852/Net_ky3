using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DrinkStores.Models
{
    public class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            StoreDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<StoreDbContext>();

            if (context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if (!context.Drinks.Any())
            {
                context.Drinks.AddRange(
                    new Drink
                    {
                        Name = "Đường nâu chân châu sữa",
                        Description = "Đồ ăn vặt",
                        Image = "1.jpg",
                        Price = 27000,
                        Discount = 1000,
                        Status = "Còn hàng"
                    },
                    new Drink
                    {
                        Name = "Cà phê việt nam",
                        Description = "Giúp tình táo",
                        Image = "2.jpg",
                        Price = 21200,
                        Discount = 12000,
                        Status = "Còn hàng"
                    },
                    new Drink
                    {
                        Name = "Cà phê ngoại nhập",
                        Description = "giúp tỉnh táo",
                        Image = "3.jpg",
                        Price = 27500,
                        Discount = 100,
                        Status = "Còn hàng"
                    },
                    new Drink
                    {
                        Name = "Sinh tố",
                        Description = "Tốt cho sức khỏe",
                        Image = "4.jpg",
                        Price = 30000,
                        Discount = 4500,
                        Status = "Còn hàng"
                    },
                    new Drink
                    {
                        Name = "Soda",
                        Description = "Giúp giải nhiệt và giải khát",
                        Image = "5.jpg",
                        Price = 2375,
                        Discount = 400,
                        Status = "Hết hàng"
                    },
                    new Drink
                    {
                        Name = "Trà",
                        Description = "Dễ uống và mức giá phải chăng",
                        Image = "6.jpg",
                        Price = 23423,
                        Discount = 230,
                        Status = "còn hàng"
                    },
                    new Drink
                    {
                        Name = "Rượu",
                        Description = "Gây hại cho sức khỏe",
                        Image = "7.png",
                        Price = 10000,
                        Discount = 500,
                        Status = "Hết hàng"
                    },
                    new Drink
                    {
                        Name = "Nướn tăng lực",
                        Description = "Giúp con người tỉnh táo",
                        Image = "8.jpgs",
                        Price = 34534,
                        Discount = 130,
                        Status = "còn hàng"
                    },
                    new Drink
                    {
                        Name = "Nước ép trái cây",
                        Description = "Bổ sung các chất cần thiết cho cơ thể",
                        Image = "9.jpg",
                        Price = 27345,
                        Discount = 1040,
                        Status = "còn hàng"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
