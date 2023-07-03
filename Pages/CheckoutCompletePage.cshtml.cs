using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyMVCShop01.Pages
{
    public class CheckoutCompletePageModel : PageModel
    {
        public void OnGet()
        {
            ViewData["CheckoutCompleteMessage"] = "Thanks For Your Order! \n That was Razor Pages!!!";
            //از دیکشنری ویو دیتا استفاده میکنیم
        }
    }
}
