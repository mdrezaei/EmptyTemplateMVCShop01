using Microsoft.AspNetCore.Mvc;

namespace EmptyMVCShop01.Controllers
{
    public class ContactController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
