using EmptyMVCShop01.Models;

namespace EmptyMVCShop01.ViewModels
{
    public class ShopingCartViewModel
    {
        public IShopingCart ShopingCart { get; }
        public double ShopingCartTotal { get; }

        public ShopingCartViewModel(double shopingCartTotal , IShopingCart shopingCart)
        {
            ShopingCart = shopingCart;
            ShopingCartTotal = shopingCartTotal;
        }
    }
}
