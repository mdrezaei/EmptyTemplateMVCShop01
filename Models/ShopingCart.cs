using EmptyMVCShop01.Models;
using Microsoft.EntityFrameworkCore;

namespace EmptyMVCShop01.Models
{
    public class ShopingCart : IShopingCart
    {
        private readonly EmptyMVCShop01DbContext _emptyMVCShop01DbContext;
        public ShopingCart(EmptyMVCShop01DbContext emptyMVCShop01DbContext)
        {
            _emptyMVCShop01DbContext = emptyMVCShop01DbContext;
        }

        public string? ShopingCartId { get; set; }

        public static ShopingCart GetCart(IServiceProvider services)
        { 
            //سرویس کالکشن اوردیم که بتونیم با دیپندنسی اینجکشن به سشن ها دسترسی داشته باشیم
            
            //IServiceProvider
            //Defines a mechanism for retrieving a service object; that is, an object that provides custom support to other objects.
            //This interface is implemented by a class or value type that provides a service to other objects.
            //The GetService method of this interface obtains the object that provides the service
            //The IServiceProvider interface is implemented by a number of types, including System.Web.HttpContext,
            //System.ComponentModel.LicenseContext, System.ComponentModel.MarshalByValueComponent, and
            //System.ComponentModel.Design.ServiceContainer
            //GetService(Type)	Gets the service object of the specified type.
            //
            //HttpContext Class
            //Encapsulates all HTTP-specific information about an individual HTTP request
            //class HttpContext : IServiceProvider
            //
            //GetRequiredService<T>(IServiceProvider)
            //Get service of type T from the IServiceProvider.
            //

            ISession? session = services.GetRequiredService<IHttpContextAccessor>()?.HttpContext?.Session;
            //اینجا میخوایم با دیپندنسی اینجکشن ریکوئست های کاربر را در سشن ذخیره کنیم

            //ISession Interface
            //Stores user data while the user browses a web application.
            //Session state uses a store maintained by the application to persist data across requests from a client.
            //The session data is backed by a cache and considered ephemeral data.
            //GetString(ISession, String)	 Gets a string value from ISession.
            //SetString(ISession, String, String)	Sets a String value in the ISession.
            //
            //??  
            //این عملگر اگر سمت چپش نال باشد سمت راستش را اجرا میکند ولی اگر سمت چپش نال نباشد مقدار چپ را ریترن میکند
            //??=
            //اگر چپ نال بود چپ را بر اساس سمت راست مقدار دهی کن اگر سمت چپ نال نبود لازم نیست کاری بکنی
            //سمت چپ ؟؟= حتمن باید متغیر یا پراپرتی یا ایندکسر باشد
            //The type of the left-hand operand of the ?? and ??= operators can't be a non-nullable value type.
            //در زمانی که چند تا از این عملگر ها پشت هم داشته باشیم از راست به چپ اجرا میشوند مثال
            //a ?? b ?? c ==> a ?? (b ?? c)
            //d ??= e ??= f ==> d ??= (e ??= f)
            //
            //Null-conditional operators ?. and ?[]
            //A null-conditional operator applies a member access, ?., or element access, ?[],
            //operation to its operand only if that operand evaluates to non-null; otherwise, it returns null
            //If a evaluates to null, the result of a?.x or a?[x] is null.
            //If a evaluates to non-null, the result of a?.x or a?[x] is the same as the result of a.x or a[x], respectively.

            EmptyMVCShop01DbContext context = services.GetService<EmptyMVCShop01DbContext>() ?? throw new Exception("Error Initialize");
            //دسترسی به دیبی کانتکست

            string cartId = session.GetString("CartId") ?? Guid.NewGuid().ToString();
            //چک میکنیم بر اساس سشنی که داریم دسترسی بهش ایا
            //از قبل برای کاربرمون کارت ایدی وجود داره یا نه
            //اگر نداریم یه ایدی بساز اگر داریم صداش بزن بر اساس ایندکسرش و مقدارش رو از سشن دریافت کن
            //در پشت صحنه ای اس پی میاد از کوکی استفاده میکنه تا با ریکوئست های مختلف یک یوزر یا
            //بهتره بگیم یک ماشین کار کند و انهارا با هم به کار بگیرد
            //

            //اگه سمت چپ ؟؟ نال باشه سمت راست جاش اجرا میشه

            session?.SetString("CartId", cartId);
            //بعد چه مقدار داشته باشه کارت ایدی یا چه ما بحش مقدار جدید بدیم به سشن ادش میکنیم

            return new ShopingCart(context) { ShopingCartId = cartId };
        }

        public void AddToCart(Pie pie)
        {
            var shopingCartItem = _emptyMVCShop01DbContext.ShopingCartItems.SingleOrDefault(s => s.Pie.PieId == pie.PieId && s.ShopingCartId == ShopingCartId);

            if (shopingCartItem == null)
            {
                shopingCartItem = new ShopingCartItem()
                {
                    ShopingCartId = ShopingCartId,
                    Pie = pie,
                    Amount = 1
                };
                _emptyMVCShop01DbContext.ShopingCartItems.Add(shopingCartItem);
            }
            else
            {
                shopingCartItem.Amount++;
            }
            _emptyMVCShop01DbContext.SaveChanges();
        }

        public int RemoveFromCart(Pie pie)
        {
            var shopingCartItem = _emptyMVCShop01DbContext.ShopingCartItems.SingleOrDefault(s => s.Pie.PieId == pie.PieId && s.ShopingCartId == ShopingCartId);

            int localAmount = 0;

            if(shopingCartItem != null)
            {
                if(shopingCartItem.Amount > 1)
                {
                    shopingCartItem.Amount--;
                    localAmount = shopingCartItem.Amount;
                }
                else
                {
                    _emptyMVCShop01DbContext.ShopingCartItems.Remove(shopingCartItem);
                }
            }
            _emptyMVCShop01DbContext.SaveChanges();

            return localAmount;
        }

        public List<ShopingCartItem> GetShopingCartItems()
        {
            return ShopingCartItems ??= _emptyMVCShop01DbContext.ShopingCartItems.Where(s=>s.ShopingCartId==ShopingCartId).Include(s=>s.Pie).ToList();
        }

        public void ClearCart()
        {
            var cart = _emptyMVCShop01DbContext.ShopingCartItems.Where(c => c.ShopingCartId == ShopingCartId);
            _emptyMVCShop01DbContext.ShopingCartItems.RemoveRange(cart);
            _emptyMVCShop01DbContext.SaveChanges();
        }

        public double GetShopingCartTotal()
        {
            return (double)_emptyMVCShop01DbContext.ShopingCartItems.Where(s => s.ShopingCartId == ShopingCartId).Select(s => s.Pie.Price * s.Amount).Sum(); 
        }

        //حالا میریم به پرگرام دات سی اس تا هر ریکوئستی که میاد به گتکارت رو اینووک کنیم

        public List<ShopingCartItem> ShopingCartItems { get ; set ; }
    }
}
