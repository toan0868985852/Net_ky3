using System.Linq;
using DrinkStores.Infrastructure;
using DrinkStores.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace DrinkStores.Pages
{
    public class CartModel : PageModel
    {

        private IStoreRepository repository;
        public CartModel(IStoreRepository repo)
        {
            repository = repo;
        }

        public Cart Cart { get; set; }
        public string ReturnUrl { get; set; }
        public void OnGet(string returnUrl)
        {
            ReturnUrl = returnUrl ?? "/";
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
        }

        public IActionResult OnPost(long drinkID, string returnUrl)
        {
            Drink drink = repository.Drinks
                .FirstOrDefault(p => p.DrinkID == drinkID);
            Cart = HttpContext.Session.GetJson<Cart>("cart") ?? new Cart();
            Cart.AddItem(drink, 1);
            HttpContext.Session.SetJson("cart", Cart);
            return RedirectToPage(new { returnUrl = returnUrl });
        }
    }
}
