
using System.ComponentModel.DataAnnotations.Schema;


namespace DrinkStores.Models
{
    public class Drink
    {
        public long DrinkID { get; set; }

        public string Name { get; set; }

        public string Description { get; set; }

        public string Image { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Price { get; set; }

        [Column(TypeName = "decimal(8, 2)")]
        public decimal Discount { get; set; }

        public string Status { get; set; }
        
    }
}
