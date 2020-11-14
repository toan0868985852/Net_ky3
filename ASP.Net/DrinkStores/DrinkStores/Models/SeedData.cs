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
                        Status = "Chất tăng lực"
       
                    },
                    new Drink
                    {
                        Name = "Cà phê ngoại nhập",
                        Description = "giúp tỉnh táo",
                        Image = "3.jpg",
                        Price = 27500,
                        Status = "Chất tăng lực"
                    },
                    new Drink
                    {
                        Name = "Sinh tố",
                        Description = "Tốt cho sức khỏe",
                        Image = "4.jpg",
                        Price = 30000,
                        Status = "Hoa quả"
                    },
                    new Drink
                    {
                        Name = "Soda",
                        Description = "Giúp giải nhiệt và giải khát",
                        Image = "5.jpg",
                        Price = 2375,
                        Status = "Chất kích thích"
                    },
                    new Drink
                    {
                        Name = "Trà",
                        Description = "Dễ uống và mức giá phải chăng",
                        Image = "6.jpg",
                        Price = 23423,
                        Status = "Chất kích thích"
                    },
                    new Drink
                    {
                        Name = "Rượu",
                        Description = "Gây hại cho sức khỏe",
                        Image = "7.png",
                        Price = 10000,
                        Status = "chất kích thích"
                    },
                    new Drink
                    {
                        Name = "Nước tăng lực",
                        Description = "Giúp con người tỉnh táo",
                        Image = "8.jpg",
                        Price = 34534,
                        Status = "Chất kích thích"
                    },
                    new Drink
                    {
                        Name = "Nước ép thập cẩm",
                        Description = "Giúp con người tỉnh táo",
                        Image = "9.jpg",
                        Price = 63345,
                        Status = "Hoa quả"
                    },
                    new Drink
                    {
                        Name = "Nước ép cà rốt",
                        Description = "Bổ sung các chất cần thiết cho cơ thể",
                        Image = "10.jpg",
                        Price = 53345,
                        Status = "Nước ép"
                    },
                    new Drink
                    {
                        Name = "Nước ép mận",
                        Description = "Bổ sung vitamin cho cơ thể",
                        Image = "11.jpg",
                        Price = 42225,
                        Status = "Nước ép"
                    },
                    new Drink
                    {
                        Name = "Nước ép ổi chanh",
                        Description = "Bổ sung các chất cần thiết cho cơ thể",
                        Image = "12.jpg",
                        Price = 272345,
                        Status = "Nước ép"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
