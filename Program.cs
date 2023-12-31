using EmptyMVCShop01.Models;

using Microsoft.EntityFrameworkCore;
//این برای بیلدر دات اس کیو ال سرور اد و یوزینگ شد
using System.Text.Json.Serialization;
//این برای ایگنور شدن سایکل ها و لوپ ها هنگام  تبدیل مدل ها و ابجکت ها به جیسان اضافه شد 
//توضیحاتش در ای پی ای سرچ موجوده

//پروگرام سی اس کلاس برنامه ما هست
//اینجا پرگرام سی اس یک کنسول اپ هست
//متد مین و کلاس و نیم اسپیس نداره
//چون از تاپ لول استیت منت استفاده کرده. تنها فایلی هست که میتونه از تاپ لول استیت منت استفاده کنه

using Microsoft.AspNetCore.Identity;
//اینو اسکافلدینگ ایدنتیتی ادش کرد
//اسکافلدینگ همچنین باعث تعغیر کانکشن استرینگ شده
//و همچنین اد دی بی کانتکس هم تعغیر کرده
//همچنین سرویس اد دیفالت ایدنتیتی رو هم اضافه کرده
//و همچنین یک فولدر جدید هم داریم به اسم اریاز که برمیگردیم داخل کامنت ها برای ادامش


var builder = WebApplication.CreateBuilder(args);//*
var connectionString = builder.Configuration.GetConnectionString("EmptyMVCShop01DbContextConnection") ?? throw new InvalidOperationException("Connection string 'EmptyMVCShop01DbContextConnection' not found.");
//اینجا وب اپلیکیشن کریت بیلدر میاد دیفالت رو برامون میاره و موقع ران میره و فایل اپ ستینگ دات جیسون رو میاره
//چک میکنه ای ای اس باشه و لوکال سرور کسترول هم باشه
//کرییت بیلدر خب مشخصا بیلدر رو کرییت میکنه برای وب اپلیکیشن
//بعد کرییت بیلدر میاد ستاپ های پایه فریمورک رو میکنه و همچنین لوکال وب سرور کسترِل رو ران میکنه و
//در انتها نرم افزار رو ران میکنه

builder.Services.AddScoped<ICategoryRepository, CategoryRepository>();
builder.Services.AddScoped<IPieRepository, PieRepository>();
//ببین هرچی درست کردیم که سرویسی رو ارائه میده بیایم اینجا رجیستر کنیم تا بعد توی کنترلر هامون وقتی که
//میخوایم بهشون و عملکرد هاشون دسترسی داشته باشیم به مشکل نخوریم

builder.Services.AddScoped<IOrderRepository , OrderRepository>();
//حالا بیلد کنیمش
//و بعد میگریشن اد کنیم براش و دیتا بیس رو اپدیت کنیم
builder.Services.AddScoped<IShopingCart, ShopingCart>(sp=>ShopingCart.GetCart(sp));
builder.Services.AddSession();
builder.Services.AddHttpContextAccessor();
//حالا میریم پایین تر و میدلور رو اد میکنیم برای ساپورت کردن سشن
//مینویسم اپ دات یوز سشن

builder.Services.AddRazorPages();
//فریمرک ریزور پیجز

builder.Services.AddControllersWithViews().AddJsonOptions(options =>
{
    options.JsonSerializerOptions.ReferenceHandler = ReferenceHandler.IgnoreCycles;
});//*
//اد کنترل ویف ویو اکستنشن متد خود فریمورک هستش و کمک میکنه تا الگوی ام وی سی قابل اجرا باشد
//از سرویس های خود فریمورک هستش
//اد جیسان اپشنز توضیحش رو دادم در ای پی ای سرچ

//builder.Services.AddScoped<ILoggerService , LoggerService() >;
//این سرویس سرویس رو ما کاستوم اوردیمش . یعنی برای فریمورک نیست
//اوردیم که بره توی کانتینر دی ای کانتینر تا در کل نرمافزار بهش دسترسی داشته باشیم
//و بعد نیازه که خط 
//var app = builder.Build();
//ساخته بشه پس در نتیجه برای اد کردن سرویس به بیلدر باید بالای اون بیلدر دات بیلد مساوی با ور اپ کد اد کردن سرویس رو نوشت

//builder.Services.AddControllers();
//برای ای پی ای هستش و ساپورت برای کنترلر هارو میاره
//ما تا الان اد کنترلرز ویف ویو رو هم اد کرده بودیم که متفاوته با این یکی
//و از اونجایی که ما کنترلرز ویف ویو رو داریم به این نیازی نداریم و میتونیم حذفش کنیم پس من امنتش میکنم


builder.Services.AddDbContext<EmptyMVCShop01DbContext>(options =>
{
    options.UseSqlServer(builder.Configuration["ConnectionStrings:EmptyMVCShop01DbContextConnection"]);
});

//builder.Services.AddDefaultIdentity<IdentityUser>(options => options.SignIn.RequireConfirmedAccount = true)
//    .AddEntityFrameworkStores<EmptyMVCShop01DbContext>();
//کارش اوردن متداول ترین ابزار ایدنتیتی هستش و کلااس ها و سرویس ها پکیج هاشون
//دقیقا مانند اد کنترلرز ویف ویو کار میکنه ولی این بار برای ایدنتیتی
//و بعد میگه از انتیتی فریمورک استفاده کن برای استور یوزر هامون در ایدنتیتی دی بی کانتکس مون 
//وسطشون یه اپشن ساین این داره که میگه فقط برای اکانت هایی که تایید شده ولی ما حذفش میکنیم تا یه چیز ابتدایی رو درست کنیم
builder.Services.AddDefaultIdentity<IdentityUser>()
    .AddEntityFrameworkStores<EmptyMVCShop01DbContext>();


builder.Services.AddServerSideBlazor();
//این برای بلیزور سرور
//میدلور هاش رو میریم پایین

var app = builder.Build();//*
//بیلدر میاد و به سرویس ها دسترسی ایجاد میکنه تا نرم افزار بتونه ازشون استفاده کنه و دسترسی داشته باشه
//و شرایط استفاده از اون سرویس ها رو ایجاد میکنه
//بیلدر میاد مجموعه سرویس ها را برای برنامه ما قابل دسترسی میکنه و سرویس ها را رجییستر میکنه
//حالا ما خودمون هم میتونیم سرویس های مدنظرمون رو به بیلدر اضافه کنیم مثلا بالای همین خط کد ور اپ مساوی با بیلدر دات بیلد
//متد بیلد میاد و مرحله قبلیش رو یعنی مرحله بیلدر رو اینیشیلایز میکنه یعنی مقدار دهی اولیه میکنه . کی رو ؟ ور  اپ رو

//app.MapGet("/", () => "Hello World!");
//از پایپ لاین های میدل ور ما هست که منتظر دریافت ریکوئست هست که به سمت روت پروژه میان. "/" این روت پروژست و مپ گت هم همونیه
//که منتظر دریافت ریکوئست هست. ور در اینجا اگه گت کنه فقط هلو ورد میفرسته. که خب در اینجا بی مصرف هست

app.UseStaticFiles();//*
//اول دقت کنیم که میدل ور رو قبل از اپ دات ران اد کنیم و زیر ور اپ بیلدر دات بیلد
//دوم اینکه اد کردن میدل ور ها به اپی که الان سرویس هاش رو بیلد کردیم ترتیب خاصی دارن
//که اون ترتیب خاص روی پرفورمنس نرمافزار تاثیر میزاره
//استتیک فایلز میره توی دبیلیو(داب) داب داب داب روت فولدر و فایل های استتیک رو میاره. مثل سی اس اس فایل ها و عکس ها
//و چون استیک هستند فقط لازمه که بیارتشون نه اینکه جنریتشون کنه پس به اخرین حلقه میدل ور نمیبره ریکوئست هایی که 
//استاتیک رو میخوان و شرت سیرکت درست میکنه تا پرفورمنس سریع تر شه

app.UseSession();

app.UseAuthentication();
//خب چون نیاز هست که دیتا بیس اپدیت بشه پس باید اول دی بی کانتکس رو اپدیت کنیم ولی
//چون قبلن ایدنتیتی دی بی کانتکس رو جایگزین کردیم
//ایدنتیتی دی بی کانتکس کار رو برای ما انجام میده فقط کافیه که ما بیلد کنیم و مایگریشن رو کریئیت کنیم
//در پکیج منیجر کنسول
//add-migration
//بعد از اد میگریشن میبینیم که انتیتی فریمورک اومده برای ما تیبل ای اس پی نت رولز ساخته و 
//ای اس پی نت یوزرز و 
//ای اس پی نت رول کلیمز و یه عالمه تیبل دیگه
//حالا
//update-database کنیم
//تمام

app.UseAuthorization();


if (app.Environment.IsDevelopment())
{
    //میاد و میدل ور پایین رو فقط در زمانی که در محیط توسعه هستیم اجرا میکنه
    //از کجا بفهمیمی هستیم یا نه
    //بریم به پراپرتیز پروژه بعد بریم سربرگ دیباگ بعد جنرال بعد پنجره رو باز کنیم و باید نوشته باشه دولوپمنت

    app.UseDeveloperExceptionPage();//*
    //کمک میکنه ارور هامون رو ببینیم
    //و چون مال دولوپر هست ارور هارو به دولوپر نشون میده نه یوزر
}

app.MapDefaultControllerRoute();//*
//این باید اخری باشه
//بعد این کاری میکنه که بشه بین ویو ها نویگیت کرد و از این ویو به اون ویو رفت و ریکوئست هارو بگیره و
//به کنترلر بده و بگیره و ویو هارو بیاره و کار های دیفالت ام وی سی رو انجام بده
//اینم منتظر گرفتن ریکوئست میمونه
//این توضیحش اینه که وقتی ریکوئست میاد برای ما که بین صفحات مختلف بریم مستقیمن نمیگه کدوم فایل اچ تی ام ال رو میخواد
//بلکه در واقع میگه کدوم اکشن ریزالت رو از کدوم کنترلر میخواد
//حالا که یو ار ال میاد در واقع ای اس پی دات نت متوجهش نمیشه 
//و برای این که متوجهش بشه باید روت بکنتش اون یو ار ال رو به کنترلر مناسبش و اکشن مناسب با اون یو ار ال
//انقدر این موضوع دیفالت هست که توی تمپلیت امپتی ای اس پی ام وی سی هم اون کد هایی که باید نوشته بشن نوشته شده هستن
//حالا این 
//app.MapGet("/", () => "Hello World!");
//یکی از اون روت هاست که فقط به گت جواب میده
//.MapDefaultControllerRoute();
//این به همه جواب میده
//و یو ار ال هارو روت میکنه به کنترلر و اکشنرزالت مناسبش بر اساس الگویی که داره
//و الگو دیفالتش هم برای روت کردن هستش 
//Controller/Action/ID
//مقدار پیش فرضشون هم برابر با 
//Controller:Home/Action:Index/ID?
//ایدی همون پارامتری هست که میدیمش به اکشن

app.MapRazorPages();
//میدل ور ریزور پیجز

//app.MapControllers();
//این هم روتینگ ای پی ای رو ساپورت میکنه ولی از اونجایی که ما مپ دیفالت کنترلرز روت رو اضافه کردیم دیگه به این هم احتیاجی
//نداریم ولی اگه فقط ای پی ای میخواستیم بسازیم فقط از این استفاده میکردیم و بیلدر سرویسس اد کنترلرز
//پس من کامنتش میکنم


app.MapBlazorHub();
app.MapFallbackToPage("/app/{*catchall}", "/app/index");
//میدلور های بلیزور
//این فال بک تو پیج با فال بک فرق داره ولی کار کلیشون یکی هست

DbInitializer.Seed(app);

app.Run();//*
//اینم که اپلیکیشن مارو ران میکنه
//اپ دات ران منتظر ریکوئست های کاربران سایت که از سایت دارن هم میشینه تا کارش رو انجام بده

//اونایی که ستاره دارن برای ران شدن وب اپی که تمپلیت خالی داره و چیز دیگه ای جز دیفالت خالی نداره لازم هستن 
//و از اونجایی که هیچ ویو نداریم صفحه 404 رو میبینیمچون هیچ کنترلری نیست که ریکوست ویو بده و هیچ ویو نیست که نشون داده بشه

//دیپندنسی اینجکشن؟
//مثلا کنترلر میخواد لاگ این کنه پس نیاز به لاگ این سرویس داره 
//کنترلر میخواد فایل بگیره پس نیاز به فایل سرویس داره
//کنترلر میخواد هر کاری کنه نیاز به سرویسش رو داره
//کنترلر کارهای زیاد و سنگینی مجبوره میشه انجام بده اینجوری و هم چنینی مشکل امنیت هم هست
//پس میایم از 
//DI contaner 
//استفاده میکنیم . دی ای کانتینرمیاد با سرویس مد نظر و اینترفیسی که براش موجود هست کاپلینک میکنه و
//بعد دی ای کانتینر دیپندنسی که ساخته رو اینجکت میکنه به کنترلر ما
//ای اس پی خودش یه دی ای کانتینر داره. کجا ؟ داخل پرگرام دات سی اس . یعنی همین جا
////builder.Services.AddScoped<ILoggerService , LoggerService() >;
//این خط بالا سرویس رو اورده به بیلدر داده و در واقع سرویس رو اورده گذاشته داخل کانتینر دی ای ما
//خب حالا از هر جای نرم افزار ما میتونیم بهش دسترسی داشته باشیم غیر مستقیم چون
//ما از هر جای نرم افزار به پرگرام دات سی اس یا همون کانتینر دی ای کانتینر دسترسی داریم
//بیلدر گفتیم رجیستر میکنه یعنی چی
//وقتی به بیلدر سرویس اضافه میکنیم تا بیاد درون کانتینر
//اون سورویس یک تایم رو برای لایف سایکلش میگیره و اینکه چجوری به اینستنسش دسترسی پیدا میکنیم
//AddTransient
//میاد با هر بار دسترسی به سرویس یک اینستنس جدید میسازه
//AddSingleton
//کلن یک اینستنس میسازه و هر بار که صدا زده بشه یا دسترسی بهش پیدا بشه همون قبلی رو میاره
//AddScoped
//در زمان درخواست و ریکوئست یک بار ساخته میشوند . خب حالا یعنی چی ؟
//یعنی ترکیب جفت رجیستر های بالا 
//یعنی وقتی یک ریکوئست بیاد یکی میسازه و اگر در زمان هندل کردن ریکوئست اولیه یک ریکوئست ثانویه برای همون سرویس بیاد 
//دیگه اینستنس جدیدی نمیسازه و از قبلی استفاده میکنه . در اسکوپ در حلقه و دوره . مثل رجیستر اد سینگلتون بود تا اینجاش
//خب حالا که ریکوئست تموم شد دیگه مثل رجیستر اد سینگلتون نگهش نمیداره و از بین میبرتش و اگر دوباره ریکوئست اومد برای
//سرویسش میاد مثل رجیستر اد ترنسینت یک اینستنس جدید میسازه
//






























































