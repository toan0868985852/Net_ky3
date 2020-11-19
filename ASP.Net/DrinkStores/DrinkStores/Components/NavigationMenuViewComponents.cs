using Microsoft.AspNetCore.Mvc;
using System.Linq;
using DrinkStores.Models;


namespace DrinkStores.Components
{
    public class NavigationMenuViewComponents : ViewComponent
    {

        private IStoreRepository repository;

        public NavigationMenuViewComponents(IStoreRepository repo)
        {
            repository = repo;
        }

        public IViewComponentResult Invoke()
        {
            return View(repository.Drinks
                .Select(x => x.Status)
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
