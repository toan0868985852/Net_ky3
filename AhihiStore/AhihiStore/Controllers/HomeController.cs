using Microsoft.AspNetCore.Mvc;

namespace AhihiStore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();
    }
}
