
using DrinkStores.Models;
using DrinkStores.Models.ViewModels;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace DrinkStores.Controllers
{
    public class HomeController : Controller
    {

        private IStoreRepository repository;
        public int PageSize = 4;

        public HomeController(IStoreRepository repo)
        {
            repository = repo;
        }

        //public ViewResult Index(int drinkPage = 1)
        //    => View(repository.Drinks
        //        .OrderBy(p => p.DrinkID)
        //        .Skip((drinkPage - 1) * PageSize)
        //        .Take(PageSize)
        //        );

        public ViewResult Index(int drinkPage = 1)
            => View(new ProductsListViewModel
            {
                Drinks = repository.Drinks
                .OrderBy(p => p.DrinkID)
                .Skip((drinkPage - 1) * PageSize)
                .Take(PageSize),
                PagingInfo = new PagingInfo
                {
                    CurrentPage = drinkPage,
                    ItemsPerPage = PageSize,
                    TotalItems = repository.Drinks.Count()
                }
            });
            

    }
}
