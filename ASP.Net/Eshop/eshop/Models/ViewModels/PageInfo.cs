using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace eshop.Models.ViewModels
{
    public class PageInfo
    {
        public int TotalItems { get; set; }
        public int ItemsPerPage{ get; set; }
        public int CurrentPage { get; set; }
        public int TotalPages => (int)Math.Ceiling((double)TotalItems / ItemsPerPage);
    }
}
