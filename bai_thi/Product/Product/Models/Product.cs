using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Text.Json;


namespace Product.Models
{
    public class Product
    {
        public string id { get; set; }
        public string name { get; set; }

        public string image { get; set; }
        
        public string price { get; set; }

        public override string ToString() => JsonSerializer.Serialize<Product>(this);
    }
}
