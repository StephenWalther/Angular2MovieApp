using Microsoft.AspNetCore.Mvc;

namespace first.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
