using EmptyMVCShop01.Models;
using EmptyMVCShop01.ViewModels;
using Microsoft.AspNetCore.Mvc;

namespace EmptyMVCShop01.Controllers
{
    public class ShopingCartController : Controller
    {
        private readonly IShopingCart _shopingCart;
        private readonly IPieRepository _pieRepository;

        public ShopingCartController(IShopingCart shopingCart, IPieRepository pieRepository)
        {
            _shopingCart = shopingCart;
            _pieRepository = pieRepository;
        }

        public ViewResult Index()
        {
            var item = _shopingCart.GetShopingCartItems();
            _shopingCart.ShopingCartItems = item;

            var shopingCartViewModel = new ShopingCartViewModel( _shopingCart.GetShopingCartTotal() , _shopingCart);

            return View(shopingCartViewModel);
        }

        public RedirectToActionResult AddToShopingCart(int pieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);

            if (selectedPie != null)
            {
                _shopingCart.AddToCart(selectedPie);
            }
            return RedirectToAction("Index");
        }

        public RedirectToActionResult RemoveFromShopingCart(int pieId)
        {
            var selectedPie = _pieRepository.AllPies.FirstOrDefault(p => p.PieId == pieId);

            if (selectedPie != null)
            {
                _shopingCart.RemoveFromCart(selectedPie);
            }
            return RedirectToAction("Index");
        }
    }
}
