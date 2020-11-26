using Microsoft.AspNetCore.Mvc;
using System.Linq;
using eshop.Models;

namespace eshop.Components
{
    public class NavigationMenuViewComponent : ViewComponent
    {
        //public string Invoke()
        //{
        //    return "Hello from the Nav View Component";
        //}

        private IStoreRepository repository;
        public NavigationMenuViewComponent(IStoreRepository repo)
        {
            repository = repo;
        }
        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedCategory = RouteData?.Values["category"];
            return View(repository.Products
                .Select(x => x.Category)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
