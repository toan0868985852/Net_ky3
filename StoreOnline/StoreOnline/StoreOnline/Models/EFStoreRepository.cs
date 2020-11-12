using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Threading.Tasks;

namespace StoreOnline.Models
{
    //tạo class EFStoreRepository   
    public class EFStoreRepository : IStoreRepository
    {
        private StoreDbcontext context;

        public EFStoreRepository(StoreDbcontext ctx)
        {
            context = ctx;
        }

        public IQueryable<Product> Products => context.Products;
    }
}
