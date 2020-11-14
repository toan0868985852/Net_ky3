using Microsoft.AspNetCore.Mvc;
using AhihiStore.Models;
using System.Linq;
using AhihiStore.Models.ViewModels;

namespace AhihiStore.Controllers
{
    public class HomeController : Controller
    {
        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }
        //public ViewResult Index(int productPage = 1) 
        //    => View(repository.Products
        //        .OrderBy(p => p.ProductID)
        //        .Skip((productPage -1) *PageSize)
        //        .Take(PageSize)
        //        );

        public ViewResult Index(int productPage = 1)
            => View(new ProductsListViewModel
            {
                Products = repository.Products
                .OrderBy(p => p.ProductID)
                .Skip((productPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = productPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Products.Count()
                }
            });
    }
}
