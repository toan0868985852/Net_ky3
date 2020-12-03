using Microsoft.AspNetCore.Builder;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Practical.Models
{
    public static class SeedData
    {
        public static void EnsurePopulated(IApplicationBuilder app)
        {
            EmployeeDbContext context = app.ApplicationServices
                .CreateScope().ServiceProvider.GetRequiredService<EmployeeDbContext>();

            if(context.Database.GetPendingMigrations().Any())
            {
                context.Database.Migrate();
            }

            if(!context.employees.Any())
            {
                context.employees.AddRange(
                    new Employees
                    {
                        Name = "Thành",
                        Image = "male-01.png",
                        Sex = "male",
                        Date = "23-10-2001"
                    },
                    new Employees
                    {
                        Name = "Bình",
                        Image = "male-02.png",
                        Sex = "male",
                        Date = "15-10-1999"
                    },
                    new Employees
                    {
                        Name = "Thắng",
                        Image = "male-03.png",
                        Sex = "male",
                        Date = "13-12-1995"
                    },
                    new Employees
                    {
                        Name = "Linh",
                        Image = "female-01.png",
                        Sex = "female",
                        Date = "01-10-2002"
                    },
                    new Employees
                    {
                        Name = "Giang",
                        Image = "female-02.png",
                        Sex = "female",
                        Date = "06-08-1995"
                    },
                    new Employees
                    {
                        Name = "Mai",
                        Image = "female-03.png",
                        Sex = "female",
                        Date = "10-10-2000"
                    }

                    );
                context.SaveChanges();
            }
        }
    }
}
