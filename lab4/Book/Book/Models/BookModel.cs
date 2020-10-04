using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.ComponentModel.DataAnnotations;

namespace Book.Models
{
    public class BookModel
    {
        [StringLength(60, MinimumLength = 3)]
        public string Title { get; set; }

        [Display(Name = "Releases Date")]
        [DataType(DataType.Date)]
        public DateTime ReleaseDate { get; set; }

        [Range(1, 100)]
        [DataType(DataType.Currency)]
        public decimal Price { get; set; }
    }
}
