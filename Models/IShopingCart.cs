namespace EmptyMVCShop01.Models
{
    public interface IShopingCart
    {
        void AddToCart(Pie pie);
        int RemoveFromCart(Pie pie);
        List<ShopingCartItem> GetShopingCartItems();
        void ClearCart();
        double GetShopingCartTotal();
        List<ShopingCartItem> ShopingCartItems { get; set; }

        //حالا شاپینگ کارت رو ایمپلیمنتش کنیم

    }
}
