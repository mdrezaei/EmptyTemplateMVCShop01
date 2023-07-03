using Microsoft.EntityFrameworkCore;
//برای ارث بری از دی بی کانتکست یوزینگ میشه
//و باید از قبل پکیج های ناگت رو اد کرده باشیم


namespace EmptyMVCShop01.Models
{
    public class EmptyMVCShop01DbContext:DbContext
    {
        //یک: کانستراکتور میسازیم کهیک اینستنس از دی بی کانتکست اپشن داشته باشه
        public EmptyMVCShop01DbContext(DbContextOptions<EmptyMVCShop01DbContext> options) : base(options) 
        {

        }

        //دو: حالا باید دی بی کانتکست ما بیاد و بر اساس کلاس ها و پراپرتی های ما این دی بی ست پر کنه و بسازه
        public DbSet<Category> Categories { get; set; }
        //میبینم که اسمش بر اساس کلاس ما هست ولی جمع هست
        public DbSet<Pie> Pies { get; set; }

        //سه حالا میریم تو اپ ستینگ تاکانکشن استرینگ رو اوکی کنیم
        //چهار : حالا میریم توی پرگرام دات سی اس تا اد کنیم سرویس هارو

        public DbSet<ShopingCartItem> ShopingCartItems { get; set; }
        //حب حالا اینجا این از دیتا بیس ما جلوتر هست پس باید میگریشن رو اپدیت کنیم تا این دوتا دوباره با هم سینک بشوند
        //مادلینگ کد ما جلوتر از دیتابیسمون هست. مدل دیتا بیسمون
        //یک میگریشن جدید باید بسازیم و بعد اپدیتش کنیم
        //خب حالا بعدش باید بریم و شاپینگ کارت رو بسازیم . میریم و یک اینترفیس میسازیم


        public DbSet<Order> Orders { get; set; }
        public DbSet<OrderDetail> OrderDetails { get; set; }    
        //اوکی بریم پرگرام تا ای اوردر ریپازیتوری رو رجیستر کنیم
        //بعد که میگریشن اد کردیم و اپدیت کردیم دیتا بیس رو 
        //بریم و کنترلر و ویو اوردر فرم رو بسازیم
    }
}
