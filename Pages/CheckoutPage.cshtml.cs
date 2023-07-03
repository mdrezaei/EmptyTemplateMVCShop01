using EmptyMVCShop01.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace EmptyMVCShop01.Pages
{
    public class CheckoutPageModel : PageModel
    //نگا اینجا یک مدل اضافه داره اخر اسم ریزور پیجمون
    {
        private readonly IOrderRepository _orderRepository;
        private readonly IShopingCart _shopingCart;

        public CheckoutPageModel(IOrderRepository orderRepository, IShopingCart shopingCart)
        {
            _orderRepository = orderRepository;
            _shopingCart = shopingCart;
        }

        [BindProperty]
        public Order Order { get; set; }
        //بایند پراپرتی میاد و مدل بایندینگ میکنه
        //حواسمون باشه با بایند پراپرتیز فرق داره

        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            var items = _shopingCart.GetShopingCartItems();
            _shopingCart.ShopingCartItems = items;

            if (_shopingCart.ShopingCartItems.Count == 0)
            {
                ModelState.AddModelError("", "Your Cart Is Empty");
            }

            if (ModelState.IsValid)
            {
                _orderRepository.CreateOrder(Order);
                _shopingCart.ClearCart();
                return RedirectToPage("CheckoutCompletePage");
            }

            return Page();
        }
    }
}
