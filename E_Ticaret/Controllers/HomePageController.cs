using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.Controllers
{
    public class HomePageController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
