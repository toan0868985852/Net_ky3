using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace web_api.Models
{
    public class BankModel
    {
        public int Id { get; set; }
        public string BankName { get; set; }
        public string IFSC { get; set; }
    }
}