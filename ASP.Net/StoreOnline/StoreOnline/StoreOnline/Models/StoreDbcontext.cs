using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;


namespace StoreOnline.Models
{
    public class StoreDbcontext : DbContext
    {
        //tạo ra kết nối database
        public StoreDbcontext(DbContextOptions<StoreDbcontext> options) 
            : base(options) { }
        
        
        public DbSet<Product> Products { get; set; }
    }
}
