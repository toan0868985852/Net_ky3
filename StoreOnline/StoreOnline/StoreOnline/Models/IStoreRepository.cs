using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace StoreOnline.Models
{
    public class IStoreRepository
    {
        //tạo repository 
        IQueryable<Product> Products { get; }
    }
}
