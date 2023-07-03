namespace EmptyMVCShop01.Models
{
    public class ShopingCartItem
    {
        public int ShopingCartItemId { get; set; }
        //پرایمری کی این هستش
        public string? ShopingCartId { get; set; }
        //ایتم هایی که درون شاپینگ کارت هستند در ارتباط با ایدی شاپینگ کارت قرار میگیرند
        //شاپینگ کارت ایدی استرینگ جی یو ای دی هست که در دیتابیس ذخیره میشن
        public Pie Pie { get; set; } = default!;
        //فارن کی هم ای دی پای از این پراپرتی و درواقع جدول هستش هستش
        public int Amount { get; set; }

        //خب حالا مدلش رو ساختیم بریم به دیبیکانتکست منون ادش کنیم
    }
}
