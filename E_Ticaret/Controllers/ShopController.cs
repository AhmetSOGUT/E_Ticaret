using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.Controllers
{
    public class ShopController : Controller
    {
        public IActionResult Shop()
        {
            return View("Shop");
        }
    }
}
