
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace StoreOnline.Controllers
{
    public class HomeController : Controller
    {
     

        public IActionResult Index() => View();
        

        public IActionResult Privacy() => View();


        public IActionResult Product() => View();


        public IActionResult Store() => View();
    }
}
