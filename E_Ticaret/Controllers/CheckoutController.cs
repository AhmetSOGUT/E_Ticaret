using Microsoft.AspNetCore.Mvc;

namespace E_Ticaret.Controllers
{
    public class CheckoutController : Controller
    {
        public IActionResult Checkout()
        {
            return View("Checkout");
        }
    }
}
