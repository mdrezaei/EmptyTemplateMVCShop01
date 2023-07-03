using EmptyMVCShop01.Models;
using EmptyMVCShop01.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmptyMVCShop01.Components
{
    public class ShopingCartSummery : ViewComponent //از ویو کامپوننت ارث بری میکنیم
    {
        //خب حالا با دیپندنسی اینجکشن بریم و به ای شاپینگ کارت دسترسی داشته باشیم تا بتونیم متوجه بشیم در هر سبد چند ایتتم وجود دارد
        private readonly IShopingCart _shopingCart;
        
        public ShopingCartSummery(IShopingCart shopingCart)
        {
            _shopingCart = shopingCart;
        }
        public IViewComponentResult Invoke()
        {
            var items = _shopingCart.GetShopingCartItems();
            _shopingCart.ShopingCartItems = items;
            var shopingCartViewModel = new ShopingCartViewModel(_shopingCart.GetShopingCartTotal(),_shopingCart);
            return View(shopingCartViewModel);
        }
    }
}
