using EmptyMVCShop01.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;

namespace EmptyMVCShop01.Controllers
{
    //[Authorize]
    public class OrderController : Controller
    {
        private readonly IShopingCart _shopingCart;
        private readonly IOrderRepository _orderRepository;
        //تا از تریغ  دیپندنسی اینجکشن بهشون دسترسی داشته باشیم

        public OrderController(IOrderRepository orderRepository, IShopingCart shopingCart)
        {
            _orderRepository = orderRepository;
            _shopingCart = shopingCart;
        }

        //The IActionResult return type is appropriate when multiple ActionResult return types are possible in an action.
        //The ActionResult types represent various HTTP status codes. Any non-abstract class deriving from
        //ActionResult qualifies as a valid return type
        //مثلن وقتی بگیم ای اکشن ریزالت برگردونه هر تابعی رو میشه برگردوند ولی اگه بگیم اکشن ریزالت برگردونه هر تابعی رو نمیشه 
        //ولی اگه بخوایم از کلاس ها و متد های ارث بری از اکشن ریزالت استفاده کنیم میتونیم از اسم خود اون تابع که برگرده استفاده کنیم
        //خوب نتونستم توضیح بدم . مثالش توی سایت سیشارپ کرنر هست . دیفرنس بتوین ای اکشن ریزالت و اکشن ریزالت
        
        
        [Authorize]
        public IActionResult Checkout()//این اکشن متد با گت کار میکنه اصن وقتی مرورگر باز میکنه سایتو فراخوانی میشه
        {
            return View();
        }

        //حالا فرم ما که داخل چک اوت هست پست میکنه دیتارو و ما میخوایم دیتای پست شده رو بگیریم
        //پس یه متد دیگه با اسم چک اوت میسازیم که ورودی اوردر میگیره و باید
        //و باید مشخص کنیم که این یکی متد وقتی باید فراخوانی بشه که ریکوئست پست رو دریافت کنه
        //و این کار رو با اتربیوت اچ تی تی پی پست مشخص میکنیم
        //ما میتونیم برای متد قبلی چک اوت که گت میکنه هم ارتبیوت اچ تی تی پی گت بنویسیم ولی
        //به صورت دیفالت خودش ریکوئست گت هستش
        //وقتی که برای متد ها ریکوئست های اچ تی تی پی رو مشخص نکنیم ریکوئست گت رو دیفالت فرض میکنه

        [HttpPost]
        public IActionResult Checkout(Order order)
        {
            var items = _shopingCart.GetShopingCartItems();
            _shopingCart.ShopingCartItems = items;
            if(_shopingCart.ShopingCartItems.Count ==0) 
            {
                ModelState.AddModelError("", "Your Cart Is Empty");
                //In short, the ModelState is a collection of name and value pairs that are submitted to
                //the server during a POST. It also contains error messages about each name-value pair, if any are found.

                //ModelState is a property of a Controller instance, and can be accessed from any class that
                //inherits from Microsoft.AspNetCore.Mvc.Controller.

                //The ModelState has two purposes: to store and submit POSTed name-value pairs, and
                //to store the validation errors associated with each value.

                //مدل استیت یه بخشی از مدل بایندینگ هستش و اگه زمانی که مدل بایندینگ داره بایند میکنه به
                //اروری بر بخوریمم میتونیم از طریق مدل ااستیت داشته باشیمش
                //
            }

            if (ModelState.IsValid)
            {
                //ModelState.IsValid indicates if it was possible to bind the incoming values from the request to
                //the model correctly and whether any explicitly specified validation rules were
                //broken during the model binding process.
                //نشان می دهد که آیا می توان مقادیر ورودی از درخواست را به مدل به درستی متصل کرد و
                //آیا قوانین اعتبار سنجی مشخص شده در طول فرآیند اتصال مدل شکسته شده است یا خیر.
                //
                //مدل استیت موقعی ولید هستش که هنگام مدل بایندینگ اروری اتفاق نیفته

                _orderRepository.CreateOrder(order);
                _shopingCart.ClearCart();
                return RedirectToAction("CheckoutComplete");
            }
            return View(order);
            //خب حالا اگه ولید نبود مدل استیت و همش خطا داشته میاد و ویو رو ریترن میکنه کدوم ویو ؟ ویو چک اوت رو
            //و اوردر رو میفرسته داخل ویو
            //این اردر را که ابجکت هست و توسط مادل بایندینگ از اطلاعات داخل اینپوت های پست شده ساخته شده است را
            //حالا ما برش میگردونیم به ویو و
            //میره و اینپوت هایی که کاربر پرکرده بود رو دوباره با توجه به اردری که فرستادیم پر میکنه
            //
            //
            //الان میخوایم یه فرم پر شه. خب اول باید نشونش بدیم. پس میایم و از متدی با اج تی تی پی ریکوئست گت استفاده میکنیم
            //بعد میخوایم این فرم رو بگیریم با اینپوت های پر شدش
            //خب فرم و اینپوت سابمیت و ای اس پی فور اطلاعات رو ارسال میکنن و حالا باید بیاد توی همون متدی که اول ویو رو نشون داده
            //ولی اون متد با گت داره کار میکنه پس ما میایم و اون متد رو اورلود میکنیم و یک متد همنام ایندفعه با
            //اچ تی تی پی ریکوئست پست و خب میخواد اطلاعات پست شده رو برگردونه به ما پس ما میایم و توی پرانتزش ابجکت کلاسی رو
            //مینویسیم که تا الان ای اس پی فور داشته پراپرتی هاش رو پر میکرده
            //
            //حالا وقتی که دیتا پست میشه وقتی بریک پوینت بزاریم میبینیم ، ابجکتی که
            //توی پرانتزش گذاشته بودیم پر شده از اطلاعاتی که توی فرم داخل اینپوت ها وارد کردیم که
            //توسط همون ای اس پی فور و مدل بایندینگ
        }

        public IActionResult CheckoutComplete()
        {
            ViewBag.CheckoutCompleteMessage = "Thanks For Your Order";
            return View();
        }
    }
}
