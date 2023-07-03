namespace EmptyMVCShop01.Models
{
    public class OrderRepository:IOrderRepository
    {
        private readonly EmptyMVCShop01DbContext _emptyMVCShop01DbContext;
        private readonly IShopingCart _shopingCart;

        public OrderRepository(EmptyMVCShop01DbContext dbContext, IShopingCart shopingCart)
        {
            _emptyMVCShop01DbContext = dbContext;
            _shopingCart = shopingCart;
        }

        public void CreateOrder(Order order)
        {
            order.OrderPlaced=DateTime.Now;

            List<ShopingCartItem>? shopingCartItems = _shopingCart.ShopingCartItems;

            order.OrderTotal=_shopingCart.GetShopingCartTotal();

            order.OrderDetails = new List<OrderDetail>();

            foreach(ShopingCartItem? shopingCartItem in shopingCartItems)
            {
                OrderDetail orderDetail = new OrderDetail()
                {
                    Amount = shopingCartItem.Amount,
                    PieId = shopingCartItem.Pie.PieId,
                    Price = shopingCartItem.Pie.Price
                };
                order.OrderDetails.Add(orderDetail);
            }

            _emptyMVCShop01DbContext.Orders.Add(order);
            //حالا اوردر رو در دی بی ست اوردرز اضافه میکنیم و بعد سیو چینجز

            _emptyMVCShop01DbContext.SaveChanges();

            //حالا بریم توی امپتی ام وی سی دی بی کانتکست و دی بی ست رو برای هر کدوم از این کلاس ها بسازیم
        }
    }
}
