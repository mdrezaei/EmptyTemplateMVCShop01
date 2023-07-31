﻿using EmptyMVCShop01.Models;
using Microsoft.Identity.Client;

namespace EmptyMVCShop01
{
    public class Comments
    {
        //توی پروژه که زیر سلوشن هست ما یک
        //Connected Services
        //داریم
        //حالا کانکتد سرویسس چیکار میکنه ؟ کارش اینه که کمک میکنه سرویس هایی رو که لازم داریم رو بتونیم رفرنس بدیم
        //حالا سرویس چیه؟ هر کلاسی که توسط نرم افزارمون استفاده بشه سرویس است
        //بعدیش دیپندنسیس هست که رفرنس های مارو لیست میکنه
        //توی پوشه پراپرتیز لانچ ستینگ دات جیسان هست کاری میکنه که اپ لانچ بشه و ران بشه
        //بعدی اپ ستینگ دات جیسان هست که برای ذخیره اطلاعات کانفیگ و کانفیگوریشن هست مثلا
        //اضافه کردن کانکشن به دیتا بیسمان و ستینگ ها
        //داب داب داب روت هست که الان اینجا نیست این یه پروژه امپتی هست که بعد ها میسازیمش
        //بعد داخل این پوشه داب داب داب روت ما فایل های استاتیک رو ذخیره میکنیم 
        //فایل استاتیک چیه ؟ فایلی هست که تعغیر نمیکنه یا با
        //ریکوست های مختلف ولیو ها و مقادیرشون تعغیر نمیکنه مثل یه صفحه سی اس اس یا یک ایمیج یا
        //یک صفحه اچ تی ام ال در کل فرانت سایت پس همه فایل هایی که براوزر برای نشون دادن وب سایت ما لازم داره
        //       ~/wwwRoot/Image.jpeg
        //       http://MyWebSite.Com/Image.jpeg
        //
        //csproj 
        //اگه کیلیک کنیم روی اسم پروژه یه صفحه باز میشه با نام پروژه که بهش میگن سی اس پروژه
        //توش ما دیپندنسی ها اد میشن و اس دی کی مایکروسافت اد میشه ورژن دات نتی که تارگت هست مشخص میشه و چیز های دیگه
        //توی سی اس پروژه یک خط کد داریم با کد زیر
        //    <ImplicitUsings>enable</ImplicitUsings>
        //کارش اینه که در دات نت 6 اومده اینو اورده تا
        //یوزینگ های دیفالت و پایه دیگه نوشته نشوند و در موقع کامپایل خودشون خود به خود به وجود بیان
        //
        //program.cs
        //توی خود پروگرام سی اس توضیح دادم
        //
        //کنتورلر ها هستند که ریکوئست هایی که به سمت سرور فرستاده میشوند از سمت اینتراکشن کاربر رو دریافت میکنن
        //و پاسخ مناسب به اون ریکوئست ها رو مهیا میکنن براساس اینتراکشن کاربر ریسپانس میدن
        //کنترلر در ریسپانس به اینتراکشن کاربر مدل رو اپدیت میکنه و
        //انتخاب میکنه که کدوم ویو در ریسپانس به اینتراکشن کاربر نشون داده بشه تا اطلاعات مدل رو نشون بده
        //وقتی ریکوئست میاد و کنترلر میگیرتش یک متد از کنترلر رو اینووک میکنه . این متد ها اسمشون اکشن یا اکشن متد هست
        //
        //Views
        //فولدر ویوز توش ویو ها نگهداری میشن اوکی
        //در فولدر ویو ما ساب فولدر هایی داریم که هم نام کنترلر های ما هستند
        //موقع ساخت کنترلر مثلا نوشتیم پای کنترلر ولی اسم این کنترلر پای کنترلر نیست بلکه پای هست پای خالی
        //حالا توی این ساب فولدر ها ما ویو داریم . از کجا بفهمیم که چه ویو یی را نشون بدیم
        //خب کنترلر ها متد دارند بعضی از این متد ها اکشن متد هستند که ای اکشن ریزالت و اکشن زیزالت برمیگردونن
        //اکثرا ویو ریترن میکنن یا ریدایرکت میکنن توی یک ویو
        //اسم این متد ها یا همون اکشن ها یا اکشن متد ها دقیقا هم نام ویو ها هستند پس
        //هروقت یکی از این اکشن ها ویو یی رو فرتخوانی میکنه ویویی میاد که هم اسم اکشن هست
        //در ویو ما اچ تی ام ال کد میزنیم و سیشارپ پس پسوندش سی اس اچ تی ام ال هستش
        //سی شارپ رو در قالب ریزور کد میزنیم یعنی با اتساین پشت سرش
        //توی ویو از لاجیک و چیز های دیگر استفاده نمیکنیم و نهایتن از ایف و حلقه استفاده کنیم . باید استفاده از سی شارپ رو کم کنیم
        //از ویوبگ کمتر استفاده میکنیم . ویوبگ را در اکشن مربوط به اون ویو مقدار دهیش میکنیم و
        //بعد با ریزر درون ویو استفادش میکنیم
        //ViewBag
        //
        //لی اوت
        //_layout
        //لی اوت میره توی پوشه شیرد
        //پوشه ای هسست که دیفالت ای اس پی میگرده دنبالش تا فایل هایی که بین همه فایل های دیگه مشترک هست رو پیدا کنه
        //الان ما برای اولین ویو خودمون یعنی ویو پای لیست دات سی اس اچ تی ام ال
        //نشستیم از صفر صفر یک اچ تی ام ال کد زدیم
        //این موضوع باعث میشه که اگه یه وقت بخوایم مثلا به نو بار چیزی رو اضافه کنیم باید بیایم و
        //دستی تمام اچ تی ام ال های ویو رو تعغیر بدیم که کار پر از اشتباه  طولانی هست
        //در عوض میایم در پوشه شیرد یک لی اوت میسازیم که در واقع یک تمپلیت برای تمام ویو های پیج ما هست
        //درون لی اوت یک کد ریزور وجود داره به اسم 
        //@RenderBody()
        //این رندر بادی اکثرا در بادی اچ تی ام ال و در تگ مین است
        //رندر بادی جایی است که کانتنت ویو های ما نمایش داده میشود
        //در واقعا اچ تی ام ال هر ویو ما رندر میشود و بعد در رندر بادی در
        //تگ مین بخش بادی لاچ تی ام ال فایل لی اوت نمایش داده میشود
        //باقی تگ ها مثل تگ هد و داک تایپ تایتل درون تگ هد و متا کر ست ها لینک های سی اس اس درون لی اوت هستند و
        //درواقع ما فقط در ویو ها در بخش مین بادی کد اچ تی ام ال میزنیم و اگر به کد هایی بیرون از
        //مین بادی نیاز داشته باشیم برای تعغیر میریم به لی اوت که البته روی تمام ویو ها تاثیر میگذارد و یا این که
        //متغیری برای تگ های بیرون از مین بادی تعریف کنیم که در ویو ها به ان ها دسترسی پیدا کنیم و از انجا تگ هایی مثل تایتل در 
        //تگ هد و متا کر ست ها را کاستومایز کنیم مختص هر ویو بدون انکه روی ویو های دیگر تاثیر بگذارد
        //وقتی که ویو رندر یشه ای اس پی اتومات میگررده دنبال یه فایل سی اس اچتی ام ال دیگه به اسم ویو استارت
        //_ViewStart
        //میایم کد هایی که میخوایم دیفالت توی ویو ها باشه رو مینویسیم اونجا . کد هایی ریزور رو
        //منظورمه حالا با یه مقدار اچ تی ام ال شاید
        //بعد با کلمه کلیدی لی اوت توی ویو استارت مشخص میکنیم که این کد ها برای کدوم ویو اجرا بشوند
        //مثلا لی اوت مساوی با لی اوت
        //این شکلی کد هایی که در اون بخش از ویو استارت هستند برای ویوی لی اوت نمایش داده میشن
        //برای لی اوت ما سه تا سی اس اچ تی ام ال اد میکنیم 
        //_Layout
        //_ViewStart
        //_ViewImports
        //
        //Shared
        //فولدر شیرد در فولدر ویو قرار میگیره و بین همه ویو ها شیر میشه
        //برای درست کردن لی اوت نیو ایتم که زدیم میزنیم ساخت ریزور لی اوت تا دیفالت لی اوت رو بسازه
        //
        //برای ساخت ویواستارت دیگه درون پوشه شیر نمیریم یک راست در پوشه ویو یک ایتم جدید اد میکنیم به اسم
        //ریزور ویو استارت
        //در ویو استارت مشخص میکنیم که لی اوتی که برای ویو ها هست کدام فایل هست
        //فایل بعدی که اضافه میکنیم ویو ایمپورت هست
        //اون هم درون پوشه ویو و بعد اد نیو ایتم و ریزور ویو ایمپورت 
        //در ویو ایمپورت یوزینگ هایی که اکثرا توسط ویو ها استفاده میشوند رو مینویسیم
        //
        //برای اد کردن لایبرری های کلاین ساید ما از لایبرری منیجمنت استفاده میکنیم نه ناگت یا حالا نوگت
        //روی پروژه کلیک راست اد کلاینت ساید لایبرری
        //پرووایدرش برابر با سی دی ان جی اس
        //بعد هم سرچ میکنیم بوت استرپ اینتر میزنیم و جدید ترین ورژنش رو میاره با اعداد جلو ورژنش
        //بعد مشخص میکنیم کدوم فایل هاش رو میخوایم . بزاریم دیفالت باشه
        //بعد میگه توی کدوم فولدر و ادرس باشه ؟
        //ما میایم پشت اون ادرسی که نوشته مینویسیم 
        //wwwroot/
        //چون یک فایل(چندین فایل) استاتیک هست و پوشه داب داب داب روت مال استاتیک هاست
        //اگه نباشه ساخته میشه اگه باشه توش اینستال میشه
        //بعد هم یک لیب من دات جیسان ایجاد میشه توی پروژه
        //که اومده با جبسان مشخصات لایبرری بوت استرپ رو که تازه اد کردیم مشخص کرده این که چه ورژنی هست اینکه کجا ذخیره هست
        //اینکه با چه پروایدری اومده و ورژن پرووایدر چی بوده
        //حالا میخوایم جی کوئری رو هم اد کنیم 
        //دوباره همین مسیر رو میریم
        //روی پروژه راست کلیک . کلاینت ساید لایبرری رو اد میکنیم و ...ه
        //ایندفعه خودش داب داب داب روت رو که ما ایجاد کرده بودیم رو اورده بود توی ادرس
        //
        //بعد هم اینکه یک قسمت دیگه که ساخت فولدر سی اس اس برای استایل دادن کاستوم خودمون هست و پوشه ایمیجز
        //اینا رو از توی خود اسست اموزش دوره اوردم : فایل سی اس اس و عکسا
        //حالا میریم توی پوشه شیرد و لی اوت و توی هد جیکوئری بوتاسترپ و سی اس اس کاستوم خودمون رو اضافه میکنیم
        //
        //
        //ای اف کور 
        //ای اف کور فقط از کد فرست ساپورت میکنه
        //برای ای اف کور باید پکیج هایی رو از ناگت اد کنیم
        //یکیش مایکروسافت دات انتیتی فریمورک دات اسکیو ال هست که برای این هست که ای اف کور بتونه با اس کیو ال کار کنه
        //بعدی هم مایکروسافت دات انتیتی فریمورک دات تولز هست که برای این هست که
        //با کنسول پکیج منیجر بتونیم دستورات انتیتی فریمورک را
        //بنویسیم و انتیتی فریمورک اجرا کنه
        //
        //حالا از اونجا که ای اف کور کد فرست هست میاد از روی دامین کلاس های ما و پراپرتی هاش انتیتی هارو میسازه 
        //ما تا الان چنتا دامین کلاس ساختیم
        //وقتی انتیتی فریمورک میاد کلاس هارو نگاه میکنه از اسم اون کلاس برای نام دادن تیبل استفاده میکنه ولی
        //به صورت جمع یعنی جمع میبندتش
        //پراپرتی ها هم سطون هارو تشکیل میدن و پراپرتی که ای دی داره میشه پرایمری کی
        //یعنی پراپرتی هایی که ایدی هستن اسمشون یا توی اخر اسمشون ای دی دارن تبدیل به پرایمری میشن
        //بعد مثلا ما توی کلاس پای یک اینت کتگوری ایدی هم داریم و بعد یک کلاس به اسم کتگوری داریم که اونم کتگوری ای دی دارد
        //در اینصورت کتگوری ایدی میشود فارن کی 
        //بعد ما یک کلاس دی بی کانتکست میسازیم که مثل پل بین اپ ما و دیتا بیس ما هست و
        //بعد هم باید کانکشن استرینگ رو بیاریم که خب به یه دیتا بیسی باید وصل بشه دیگه
        //کجا میاریمش؟ توی اپ ستینگ دات جیسون
        //توی پراگرام دات سی اس هم یکم کد کانفیگی داریم که خب چون سرویس ها و پکیج های مختلفی رو اوردیم دیگه
        //ای اس پی خیلی ماژولار هستش و پس باید چیز هایی که میخوایم رو اضافه کنیم هی
        //توی پرگرام دات سی اس از بیلدر دات سرویس دات اد دی بی کانتکست که یک اکستنشن متد هست استفاده میکنیم تا
        //دیتا بیس کانتکس ما رجیستر بشه
        //ما کانکشن استرینگ رو میفرستیم و دی بی کانتکست رو میفرستیم و ناگت پکیج هارو میفرستیم تا بتونیم ازشون استفاده کنیم
        //
        //خب اولین کار اد کردن پکیج ها با ناگت
        //خب بعد اطلاعاتش تیو سی اس پراجک میاد که همونیه که اگه روی پروژه کلیک کنیم میاد
        //خب حالا بریم دیتا بیس کانتکس رو بسازیم
        //خب میریم توی پوشه مادلز و یه کلاس با اسم پروژهبه همراه دی بی کانتکست میسازیم و از دیبیکانتکست م ارث بری میکنیم
        //
        //
        //کانکشن استرینگ رو نوشتیم چجوری نوشتیم ؟ به اپ ستینگ نگاه کنیم
        //https://www.connectionstrings.com/
        //از این سایت کمک میگیریم
        //بعد هم چون حالا من اس کیو الم سرتیفیکیتش ساین نشده و ترو نیست میایم و
        //کد پایین رو اضافه میکینیم به درون انتهای کانکشن استرینگمون
        //TrustServerCertificate=True;
        //
        //میگریشن یعنی محاجرت از یک محیط به محیط دیگر خب ما الان میخوایم که کلاس ها و پراپرتی های توش رو برداریم ببریم اس کیو ال
        //
        //Add-Migration: Creates a new migration class as per specified name with the Up() and Down() methods.
        //Update-Database: Executes the last migration file created by the Add-Migration command and
        //applies changes to the database 
        //
        //خب حالا برای اینکه دیتا رو وارد دیتا بیس کنیم میایم و یک کلاس برای سید دیتامون درست میکنیم در پوشه مادلز
        //
        //
        //پارشال ویو ها
        //پارشال ویو مال وقتی هست که ما یک ویو داریم و اون ویوی یک کار خاصی رو انجام میده و
        //یک ویو دیگر هم داریم و کار قبلی رو انجام میده
        //اینجا ما جای اینکه از چند ویوی مختلف ولی با کار همسان استفاده کنیم میایم و از یک پارشال ویو استفاده میکنیم
        //پارشال ویو ها با اندرلاین و بعد حرف بزرگ شروع میشوند و در پوشه شیرد ویو قرار میگیرند
        //اول یک ویو در پوشه شیرد بسازیم
        //بعد در جایی که میخوایم از کد های پارشال ویو استفاده کنیم از تگ هلپر پارشال استفاده میکنیم
        //و اتربوت نیم رو که میگه اسم پارشال ویو چی هست رو پر میکنیم و چون در پوشه شیرد هست نیازی به ادرس دهی نیست
        //
        //
        //خب حالا وقتی که ما در خواستی رو ارسال کنیم بعد از انجام اون درخواست و ریکوپست اون ریکوپست حذف میشه
        //پس مثلن توی سبد خرید مشتری وقتی چیزی رو اضافه میکنه بعد که میره صفحه بعد اون چرخ خرید حذف میشه اگه ما جایی ذخیرش نکرده باشیم
        //حالا اگه کاربرمون بدون درست کردن حساب کاربری بخواد خرید انجام بده چی؟ اون موقع کجا ذخیره کنیم 
        //میایم و با سشن ها ذخیره میکنیم 
        //سشن ها اطلاعات رو در کوکی ها ذخیره میکنن و اینشکلی هست که ذخیره میشه تا وختی ریکوئست انجام شد اطلاعاتش حذف نشه
        //در کوکی ذخیره میشه و بر اساس ای پی و مرورگر طرف ذخیره میکنه
        //و این که ما هر ریکوئست سبد خرید رو بایک جی یو ای دی 
        //GUID 
        //مشخص میکنیم که ای دی یونیک داشته باشه برای کاربر ها
        //مثل باقی ابزارهای فریمورک باید اضافه بشه ولی چون دیفالت هست لازم نیست که
        //از ناگت پکیج استفاده کنیم و همین جوری میایم و اضافش میکنیم در پرگرام دات سی اس
        //مینویسم اد سشن
        //و بعد مینویسیم یوز سشن
        //
        //
        //ویو کامپوننت
        //مشابه پارشال ویو هستند با این تفاوت که پارشال ویو یک تک دیتا بهش بر اساس کنترلری که صداش میزنه و ویو مادر میرسه ولی
        //چی میشه اگه چنتا دیتا به خایم بدیم بهش و اینا ؟ اون موقع میایم از ویو کامپوننت استفاده میکنیم که
        //بخش کد زدن و لاجیک مجزای خودش رو داره
        //از اونجایی که هم لاجیک خودش رو داره هم با دیتا بهتر و وسیع تر کار میکنه و از دیپندنسی اینجکشن پشتیبانی میکنه پس
        //میشه ازش در فرم های لاگ این استفاده کرد
        //برای نویگیشن داینامیک که بر اساس اینکه کاربر لاگ این کرده یا نه تفاوت کنه
        //و برای سبد خرید که خب ایتم های مختلف توی سبد هستند
        //ویو کامپوننت کلاس
        //یک کلاس ویو کامپوننت میسازیم که از ویو کامپوننت ارثبری میکنه و پابلیک هست و ابسترکت هم نیست
        //کاری که میخوایم انجام شه را درون متد اینووک مینویسیم که باید باشهد چون ای اس پی به صورت دیفالت میگرده دنبالش و برامون میارتش
        //در مسیر پوشه ویو پوشه شیرد پوشه کامپوننتس و پوشه ای که هم اسم کلاس کامپوننت ویو هست و ویو اونجا قرار میگیره با اسم دیفالت 
        //برای کلاس کامپوننت ویوها یک فولدر میسازیم به اسم کامپوننتس در پروژه و بعد در انج یک کلاس ساده میسازیم
        //
        //
        //
        //درست کردن تگ هلپر کاستوم
        //تگ هلپر چیکار میکنه؟
        //تگ هلپر باعث میشه کد های سی شارپ سمت سرور در رندر شدن و
        //ساخته شدن صفحات اچ تی ام ال با کد های اچ تی ام ال همکاری کنند در ریزر فایل 
        //تگ هلپر ها هاوی سی شارپ اند و اون سی شارپ باعث ساخته شدن اچ تی ام ال میشه
        //تگ هلپر با استفاده از سی شارپ ساخته میشوند . تگ هلپر ها یک کلاس اند که از کلاس تگ هلپر ارث میبرند
        //تگ هلپر ها سرور ساید اند که باعث ساخته شدن اچ تی ام ال میشوند
        //
        //برای ساخت تگ هلپر
        //یک فولدر بسازیم در پروژه ویک کلاس در ان اد کنیم
        //حالا از کلاس تگ هلپر در نیم اسپیس مایکروسافت دات ای اس پی نت کور دات ریزور دات تگ هلپر ارث بری میکنیم
        //الان اسم کلاس تگ هلپر ما به این شکل هست
        //EmailTagHelper
        //ای اس پی میاد و به صورت دیفالت تگ هلپری با اسم 
        //Email
        //میسازه یعنی به صورت دیفالت اسم تگ هلپر برابر با کلمه یا کلمات پشت کلمه تگ هلپر است
        //خب حالا بریم توی کلاسمون
        //
        //
        //
        //الان ما فرم رو درست کردیم 
        //فرم پست هم میکنه
        //ولی به دیتاش دسترسی نداریم
        //اگه بخوایم دستی ریکوئست های اچ تی تی پی رو بگیریم
        //یه عالم کد میخواد
        //ولی با مدل بایندینگ دیگه نمیخواد خودش میاد اینپوت های پست شده رو میبره توی اکشن ما و پارامتر هایی از 
        //اکشن متد را که نیازه پر بشن پر میکنه
        //
        //
        //
        //
        //خب حالا کاربران باید وقتی فرم رو پرمیکنند با دیتایی پر کنند که بشه مدل بایندینگشون کرد و پراپرتی های ابجکت کلاسمون رو 
        //به درستی پر کنه
        //ولیدیشن لازم داریم 
        //ولیدیشن رو همون مدل استیت انجامش میده
        //پیغام خطا رو هم همون مدل استیت نشونش میده
        // و در اخر چک میکنه ایز ولید؟ اگر تروو بود که حله
        //IsValid
        //GetValidationState
        //AddModelError
        //و اینکه میتونیم ولیدیشن اتربیوت هم به کلاس مدل مان اظافه کنیم که خود مدل ولیدیشن رو انجام بده
        //چنتا از اتربیوت ها
        //Required 
        //ما وقتی هست که یک پراپرتی لازم باشد اینو برای اون پراپرتی میزاریم
        //StringLength
        //برای مشخص کردن کمترین و بیشترین تعداد کارکتر پراپرتیمون
        //Range
        //پراپرتی عددیمون توی رینج و بازه مشخص ما هستش یا نه
        //RegularExpression
        //اتربیوت رگولار اکسپرشن که مخففش میشه رجکس
        //regex
        //رگولار اکسپرشن یا رجکس میاد و یک الگوی متنی رو چک میکنه
        //A regular expression is a sequence of characters that specifies a match pattern in text.
        //A regular expression (also called regex or regexp) is a way to describe a pattern
        //to locate or validate specific strings or patterns of text in a sentence, document, or any other character input.
        //با رگولار اکسپرشن میشه مثلا ایمیل و شماره تلفن رو هم ولیدیشنش رو چک کرد 
        //ولی هم ایمیل و هم شماره تلفن اتربیوت خودشون رو دارن
        //EmailAddress
        //Phone
        //اتربیوت های شماره تلفن و ایمیل
        //بعد خب ما پیام های ولیدیشن رو هم باید نشون بدیم دیگه ، درواقع ارور مسیج هارو
        //ارور مسیج ها رو میتونیم توی ویو با تگ هلپر 
        //asp-validation-summery
        //نشون بدیم
        //کلاس این تگ هلپر میاد میره توی اکشن متدش و میگرده دنبال خطا و اگه اروری بود پیامش رو میگیره و میاد 
        //در جایی که این تگ هست که اکثرن داخل تگ های فرم در یک دیو هست نشونش میده
        //خب حالا بریم توی مدل اوردرمون و اتربیوت های ولیدیشن رو اضافه کنیم
        //
        //
        //
        //
        //خب این تا اینجا ام وی سی بود
        //حالا میخوایم بریم ریزور پیجز
        //برای ریز پیجز نیازی نیت که ما کنترلر بسازیم
        //یکدونه ویو داره با پسوند همون سی اس اچ تی ام ال
        //اون سی اس اچ تی ام الش یکدونه کد بیهایند داره
        //که از کلاس 
        //PageModel 
        //ارث بری کرده
        //روتینگ توی ریزور پیجزبا روتینگ توی ام وی سی متفاوته
        //و بر اساس فایل هستش
        //میتونیم ریزور پیجز و ام وی سی رو با هم استفاده کنیم
        //از ام وی سی برای پیج هایی که لاجیک پیچیده ای دارن استفاده میکنیم
        //خب برای استفاده ازش توی پروژه ما باید بریم توی پرگرام دات سی اس و این فریمورک رو رجیستر کنیم 
        //بعد از رجیستر سرویس حالا رجیستر میدلور ان با استفاده از 
        //app.MapRazorPages
        //چرا میدل ور رو اد کنیم چون گفتم که این روتینگش متفاوته و میاد اینفایل هایی که
        //توی فولدر پیجز هستند رو به عنوان اند پوینت ریزور پیجز مشخص میکنه
        //در فایل ریزور پیجز ما در ابتدای کد ها از 
        //@page
        //استفاده میکنیم چون ما کنترلر و اکشن متد نداریم از این استفاده میکنیم و این فایل ریزور پیجز رو تبدیل میکنه به ام وی سی
        //ات پیج همیشه باید اولین خط باشه و اینکه فایل ریزور پیج میره داخل فولدر پیجز
        //کد بی هایند ریزور پیجز با ویو ان هم نام هست با این تفاوت که بعد از سی اس اچ تی ام ال پسوند دات سی اس دارد 
        //کد بی هایند که از پیج مادل ارث بری میکنه هندلر متد داره که از پیج مادل میان
        //OnGet()  &  OnPost()
        //این دوتا هندلر کار پست و گت رو انجام میدن و اکشن ریزالت بر میگردونن
        //خب حالا بریم و سرویس ریزر و میدل ور ان را اضافه کنیم و 
        //حالا نیازه که فولدر پیجز رو بسازیم چون اون فولدری هست که به صورت دیفالت روتینگ ریزور پیجز بهش رجوع میکنه
        //بعد داخل اون فولدر ریزر پیج میسازیم حواسمون باشه ریزر ویو نسازیم
        //کد بی هایند ش هم زیر مجموعه و همنام همین ریزور پیجی هست که ساختیم و
        //
        //
        //
        //
        //یونیت تست
        //یونیت تست کد هایی هستند که به شکل اتومات میان و عملکرد و رفتار یونیت ها و بخش های کد ما رو میسنجن
        //یک یونیت همون بلاک کد هست که خب کوچیکترینش متد ها هستند
        //اکثرن میان و متد های پابلیک رو میسنجن که بتونن دسترسی داشته باشن کدهای یونیت تست میان یونیت هارو در حالت
        //ایزوله و مسقل چک میکنن پس رفرنس ها مشکل ساز میشه البته چون ما دیپندنسی اینجکشن استفاده میکنیم جای نگرانی وجود نداره چون 
        //میتونیم راحت از دیپندنسی اینجکشن با استفاده از یک نمونه ماک اون متد یا کلاس خارجش کنیم و تستش کنیم
        //یونیت تست باید سه ویژگی داشته باشه
        //یک نتایجش مستمر باشه یعنی وقتی چندین بار یک یونیت تست میشه نتایج تست یکسان باشه که چون ایزوله هستند اکثرن این اتفاق میفته
        //دو اینکه به صورت خودکار تست هارو انجام بده
        //سه اینکه سریع باشه چون یک نرم افزار چندین تست داره و چندین بار تست میشه
        //یکی از بهترین راه ها برای داکیومنت کردن کد و افزایش بهره وری کد
        //و افزایش کیفیت کد و جلوگیری از کار نکردن تعغیرات و پیدا کردن باگ ها یونیت تست و نتایج و سوابق یونیت تست هست
        //نوشتن یونیت تست
        //AAA Approach
        //arrange ترتیب دادن
        //act عمل کردن
        //assert ادعا کردن
        //بیشتر یونیت تست ها از این رویکرد پیروی میکنن
        //اول از همه ما باید برای تست بعضی چیز ها رو مهیا کنیم . این از بخش ارینج
        //اکت هم مال وقتی هست که کد های تست رو اگزکیوت میکنیم
        //اسرت هم برای نتایج تست و تایید نتایج تست هستش
        //در بیشتر یونیت تست ها ما یک عدد اسرشن داریم ولی بعضی جاها هم چند تا برای یک تست
        //
        //یونیت تست فریمورک های داره ما از فریم ورک اکس یونیت استفاده میکنیم
        //xUnit
        //بعد لازمه که ماک ورژن هر کدوم رو هم ما بسازیم
        //پس باز ما از فریم ورک 
        //Moq
        //استفاده میکنیم
        //
        //نمونه یک تست
        //
        //public void CanUpdatePiePrice()
        //{
        //    //Arrange
        //    var pie = new Pie() { Name = "Simple Pie", Price = 12 };
        //
        //    //Act
        //    pie.Price = 20;
        //
        //    //Assert
        //    Assert.Equal(20, pie.Price);
        //}
        //
        //خب برای اضافه کردنیونیت تست ما باید در داخل سلوشن یک پروژه جدید اضافه کنیم پس کلیک راست روی پروژه و
        //اد نیو پروژکت . این پروژه 
        //xUnit 
        //هستش . سرچ میکنیم اک یونیت رو و اضافه میکنیم همون پروژه رو
        //پروزه اکس یونیت تست پروژکت رو انتخاب میکنیم دقت کنیم زبان سی شارپش رو
        //انتخاب کنیم هم اسم پروژه خودمون با یک تستس اضافه در اخرش
        //دیفالت یک عدد فایل دات سی اس به اسم یونیت تست یک وجود داره . اون رو پاکش کنیم و مال خودمون رو درست کنیم
        //اگه رو اسم پروژه تستمون کلیک کنیم میبینم که اکس یونیت رفرنس داده شده حالا ما
        //در تگ ایتم گروپ میایم و پکیج ماک رو رفرنس میدیم خودمون با تگ  پکیج رفرنس
        //همچنین ما باید پروژه خودمون رو هم به پروژه تست رفرنس بدین تا بشه تستش کرد
        //پس روی پروژه تست کلیک راست اد پروژکت رفرنس
        //بعد میبینیم که رفرنسش به رفرنس های پروژه تست اضافه شده در تگ ایتم گروپ جدا
        //خب حالا مثلن ما میخوایم که یک کنترلر رو تست کنیم
        //این کنترلر مثلن داره از دیپندنسی اینجکشن استفاده میکنه و کانستراکتورش دو تا ایتم میگیره مثلن 
        //پای کنترلر دوتا داره یکی ای پای ریپوزیتوری و یکی هم ای کتگوری ریپوزیتوری
        //کانستراکتور پای کنترلر لازم داره این دو ایتم رو این ایتم ها با دیپندنسی اینجکشن محیا میشوند ولی اینجا در تست
        //ما باید ورژن ماک ان هارو درست کنیم
        //و میخوایم پای لیست رو تست کنیم اول ببینیم که چیکار میکنه
        //یه استرینگ میگیره چک میکنیم اگه خالی بود همه کتگوری هارو برمیگردونیم و کورنت کتگوری هم میشه ال پایز 
        //اگر خالی نبود میاد پای ها رو فیلتر میکنه و فقط پای های همون کتگوری برابر با استرینگ رو نشون میده و
        //کورنت کتگوری هم میشه هم اسم کتگوری که با استرینگ برابر هست و بعد
        //ویو مدلی رو به عنوان پارامتر به ویو میفرسته که خودش به عنوان پارامتر پای های انتخاب شده توسط کتگوریشون و
        //مقدار کورنت کتگوری رو دریافت میکنه
        //خب حالا ما توی پروژه تست یک فولدر میسازیم فقط برای اینکه همه چیز مرتب باشه اسمش رو هم میزاریم کنترولر که
        //یعنی کنترلر هارو توش تست میکنیم
        //یک کلاس پابلیک میسازیم اون تو 
        //لازم نیست این کلاس از چیزی هم ارث بری کنه

        //test for commit changes

        //http verbs
        //Get
        //Post
        //Put

        //Get
        //گت یعنی یه نتیجه ای رو به من بده

        //Post
        //این برای وقتیه که بخوایم یک چیز جدیدی رو بسازیم
        //مثلن موقع فرستادن اطلاعات پای میخوایم یک پای جدید رو بسازیم میفرستیم که اطلاعات بره
        //قبلی میگفت نتیجه به من بده این یکی میگه بیا یک نتیجه بهت بدم یک اطلاعاتی رو بهت بدم

        //Put
        //برای اپدیت اطلاعات هست

        //Delete
        //برای دلیت اطلاعات هست

        //api
        //ای پی ای یک یا چنتا کنترلر هستش که با اچ تی تی پی بهش وصل میشن و بعد توسط اکشن متد هایی که داره دیتا رو که اکثرن به 
        //شکل جیسان هست بر میگردونه . ریترن میکنه

        //خب برای ای پی ای ما میایم و در پرگرام دات سی اس کنترلرز رو اد میکنیم و مپ میکنیم 
        //مپ کنترلرز که برای میدلور هستش و ادکنترلرز هم که برای اضافه کردن سرویسش

        //کلاس ای پی ای درواقع همون کنترلر هستش. بعد از اسم ای پی ای مان کلمه کنترلر میاد و مشابه همون کنترلر هستش
        //ولی از کنترلربیس ارث بری میکنه جای اینکه از کنترلر ارث بری کنه کنترلر بیس ویو ساپورت نداره ولی باقی چیز هایی را
        //که نیاز داشته باشیم داره . به کاملی کنترلر نیست ولی خب اچ تی تی پی ریکوئستت هارو داره 

        //روتینگ در ای پی ای ها متفاوته
        //در ام وی سی که ما از دیفالت هم استفاده کردیم بر اساس یو ار الی که میاد و اند پوینت میرسه ای اس پی میاد و
        //با تمپلیت هایی که در روتینگش داره اون اندپینت هارو چک میکنه و بر اساس
        //اون تمپلییت ها اکشنی رو از کنترلری فراخوانی میکنه
        //به این حالت میگن کانونشن بیس روتینگ
        //Convention-Based Routing
        //اگر چه ای پی ای میتونه از این روتینگ استفاده کنه ولی کار درستی نیست
        //پس میایم و از اتربیوت بیس روتینگ استفاده میکنیم
        //Attribute-Based Routing
        //در اتربیوت روتینگ ما میایم و بالای کنترلر اتربیوت روت رو استفاده میکنیم که یک استرینگ میگیره
        //[Route("api/[controller]")]
        //اتربیوت روت که استرینگ میگیره میبینیم که نوشتیم ای پی ای اولش 
        //خب این رو نوشتیم چون معمولن نوشته میشه که مشخص بشه برای ای پی ای هستش
        //میتونیم هم ننویسیم
        //بعد از اسلش اسم کنترلری که میخوایم بهش روت بشیم رو مینویسیم مثلن اگه پای کنترلر هست پای
        //ولی چون امکان داره که هی اسم کنترلر رو تعغیر بدیم و بعدش مجبور بشیم اسم روتینگ رو
        //هم تعغیر بدیم میایم و از پلیس هلدر کنترلر استفاده میکنیم
        //توی کانونشن روتینگ مسئله ای که هست اینه که اکشن متد ها و کنترلر ها ، ویو ها و
        //پولدر های هم اسم خودشون رو دارن ولی توی اتربیوت روتینگ همچین اینجوری ها هم نیست
        //برای این ما میایم و بالای اکشن متد ها از اتربیوت های اچ تی تی پی ورب استفاده میکنیم مثل
        //[HttpGet]
        //[HttpGet("{id}")]
        //[HttpPost]
        //این مال وقتی هست که اکشن متدی باید گت کنه و مال وقتی هست که باید یک ای دی گت کنه و مال وقتی هست که باید پست کنه
        //توی این اتربیوت ها مدل بایندینگ هم هست و کار میکنه اتو مات
        //مدل بایندینگ چک میکنه که اون ایدی که ارسال داره میشه با ایدی که توی متد هست وصل باشه و همون باشه
        //حالا اگه یک ابجکت باید گت میشد و برای اکشن متد به عنوان ورودی میومد چی
        //مدل بایندینگ و جیسون در اون متد پست یا حتی گت
        //کلن مدل بایندینگ اینجا نقش کلیدی داره به این شکل که میفرسته یو ار ال رو و میره به سمت کنترلری که اتربیوت داره
        //بعد میگرده توی اتربیوت های اچ تی تی پی گت و اگر یو ار ال ایدی برگردونه میگرده دنبال گتی که ایدی قبول کنه


        //خب حالا ای پی ای شبیه کنترلره و کنترلر های ام ویسی ولی فرق دارن چون ویو دارن . پس کنترلر ای پی ای رو کجا کنیم؟
        //یه ساب فولدر درست میکنیم داخل فولدر کنترلرز و اسمش رو میزاریم ای پی ای با ای بزرگ
        //خب داخل اون فولدر ما یک ایتم جدید اد میکنیم که ای پی ای کنترلر هست 
        //در نام گذاری هم انتهای نامش کنترلر میاد


        //ما میخوایم که از جیکوئری و ایجکس برای ای پی ایمون استفاده کنیم
        //کار ایجکس اسینکروس یا همون ناهمزمان هست که خب کاری میکنه که زمانی که ریکوئستی ارسال میشه همه
        //پیچ به اون ریکوئست واکنش نشون نده و رفرش نشه
        //برای این باید جیکوئری رو اد کنیم 
        //جیکوئری رو از قبل اد کردیم توی پوشه داب داب داب روت
        //خب حالا ببریم توی پای کنترلر و ی ویو به اسم سرچ برگردونیم









        //بلیزور با سی شارپ و اچ تی ام ال میاد و فرانت اندی اینتراکتیو درست میکنه
        //دو حالت داره حالت اول بلیزور وب اسمبلی هست که تمامن سمت کاربر کد هاش اجرا میشه و اثرشون رو نشون میدن 
        //چون بر مبنای وب اسمبلی هست به اسم بلیزور وب اسمبلی شناخته میشه
        //
        //بلیزور بعدی بلیزور سرور یا بلیزور خالی صدا میشه
        //چون حالت پایه بلیزور هست و کد هاش به جای اینکه سمت کاربر باشه سمت سرور اجرا میشه و اثرش رو میفرسته سمت کاربر تا 
        //اثرش دیده بشه . بر مبنای وب اسمبلی هم نیستش و مشخصا اگر کاربر زیادی وجود داشته باشه روی سرور فشار میاره
        //
        //
        //میشه همراه با بلیزور از جاوا اسکریپت هم استفاده کرد اگه خواستیم
        //
        //
        //چرا سرور ساید کار درستی نیست چون بلیزور برای این که یو ای رو کنترل کنه میاد و برای هر
        //کاربری که به سرور دسترسی پیدا میکنه یک اپلیکشن بلیزور میسازه و هر کاربر جدید یک اینستنس جدید و این اپ رو
        //روی مموریش در حال اجرا نگه میداره
        //بلیزور از سیگنال ار هم استفاده میکنه که اطلاعات رو ریلتایم برای یو ای از
        //سرور به سمت کلاینت بفرسته که نرمافزار رو رفرش نکنن
        //
        //
        //سرویس بلیزور رو که باید اد کنیم که هیچی برای روتینگش هم از روتینگ خودش استفاده میکنه مثلن
        //اگه هیچ کامپوننتی رو توی اند پوینتش پیدا نکنه باید فال بک بشه
        //فال بک بشه به صفحه ای که روش هاست هستش و میزبانی میشه کامپوننت هاش
        //_Host
        //و نه پیج داره نه ویو بلکه کامپوننت داره
        //کامپوننت میتونه یک باتن باشه یا یک پیج باشه
        //کامپوننت حاوی مارک اپ کد ریزور کد و سی شارپ هست و کامپوننت ها میتونن درون هم نست بشوند
        //مثلن ما یک پیج داریم که کامپوننت هست و
        //درونش چندین کامپوننت دیگه و درون ان کامپوننت های درن این پیج کامپوننت های دیگه ای هم هستند
        //ما حتی میتونیم از اون پیج که خودش هم کامپوننت هست به عنوان کامپوننت درون یک پیج دیگر که ان هم کامپوننت هست استفاده کنیم
        //با ات ساین پیج هم شروع میشوند
        //@page
        //در ات ساین کد هم کدشون رو مینویسیم کهکد سیشارپ هست و ات ساین کد ریزور هستش
        //@code
        //ولی استفاده از ات ساین کد کار درستی نیست و
        //باید هم نام کامپوننت مون یک کلاس  پابلیک و پارشیال در کد بیهایند داشته باشیم
        //البته که پیج داره ولی ما از لفظ کامپوننت استفاده میکنیم
        //البته که پیج هارو پیج صدا میکنیم پیج خودش بخشی از کامپوننت هستش



        //خب برای اضافه کردن بلیزور بریم توی پروگرام دات سی اس و
        //AddServerSideBlazor();
        //که کارش اینه که خب پکیج بلیزور برای سرور ساید رو اضافه کنه به پروژه
        //بعد در پایپ لاین باید میدلوری رو اضافه کنیم که روت و پف رو با سیگنال ار برای ما هندل و ردیف کنه
        //app.MapBlazorHub();
        //مپ که روتینگشه بلیزور هم که بلیزور هست و هاب بیس کلاس سیگنال ار هست یعنی
        //بره و یو ای بلیزر رو به شکل ناهمزمان و ریل تایم اپدیت کنه حالا چرا روتینگ اینجاست ؟ چون
        //هر ریکوئستی یک روت هستش دیگه و باید روتش باشه تا میدلور از جایی که
        //ریکوئستش فرستاده میشه بره بر اساس اون روت جایی که اطلاعات هست اطلاعات رو برداره و برای ما بیاره
        //میدلور بعدی 
        //app.MapFallbackToPage(..... , ......)
        //هستش که ما پرانتزش رو از سمت چپ اینجوری پر میکنیم که هرچی رفت به این یو ار الی که نوشتیم ریدایرکت بشه به یو ار الی که
        //سمت راستش نوشتیم و فال بک بشه
        //فال بک یعی وقتی پیجی رو پیدا نمیکنه یا ارور میگیره ، بعضی ارور ها، بیاد و برگرده به
        //پیجی که روش داره اون سرویس هاست میشه
        //پیجی که داره روش هاست میشه هم توش اطلاعاتی هست که کدوم تگ هلپر ها فعال باشند کدوم ویو ویو لی اوتش باشه و
        //کدوم پیج و کامپوننت اصلی باشن موقع اجرا و چه کامپوننت ها و پیج ها و ککد بیهایند هایی مدل بشن در بالای صفحه 
        //در پرانتز فال بک تو پیج مانند زیر مینویسیم
        //("/app/{*catchall}", "/app/index")
        //میگه هر ریکوئستی که به اپ اسلش حالا هر چیزی (جدی هر چیزی که توی یو ار ال بود) ختم شد بره به اپ اسلش ایندکس
        //فال بک بشه به پیج ایندکس . ریدایرکت بشه به پیج ایندکس
        //حالا بعدن میایم داخل پوشه پیجز یه پوشه به اسم اپ میسازیم و بعد پیج هامون رو میریزیم داخلش

        //خب پیج های بلیزور از جنس دات ریزور هستند و یه فایل کد بیهایند دارند با پسوند دات ریزور دات سی اس
        //از اپروچ
        //approach
        //از رویکرد میکس که در فایل دات ریزور تمام کدهارو میزنیم بهتره که استفاده نکنیم و
        //در کنار اپروچ کد بیهایند استفادش کنیم
        //سعی کنیم که کمتریم استفاده رو از رویکرد میکس داشته باشیم و حداکثری رو از کد بیهایند
        //فایل کد بیهایند که پسوند دات ریزور دات سی اس داره داخلش یک کلاس هم نام با پیج بلیزورمون هست که پابلیک و پارشیال هستش
        //همینطور که باید جفت فایل ها فایل پیج بلیزور و فایل کد بی هایندش هم هم نام باشند


        //برای فریمورک ای اس پی ایدنتیتی باید ناگت پکیج اضافه کنیم
        //microsoft.aspnetcore.identity.entityframworkcore package
        //پس روی پروژه نه روی سلوشن کلیک کرده و منیج ناگت پکیج رو میزنیم
        //پکیج بالایی رو سرچ میکنیم نصب میکنیم و بعد پکیج پایینی رو هم سرچ میکنیم و نصب میکنیم
        //microsoft.aspnetcore.identity.ui

        //بعد از دانلود و نصب پکیج ها باید دی بی کانتکس پروژه رو اپدیتش کنیم
        //EmptyMVCShop01DbContext
        //این بالایی رو میگم

        //خب حالا اول بریم میدلور اتنتیکیشن رو اضافه کنیم
        //اتنتیکیشن یعنی اینکه ببینیم که فرد واقعی هست یا نه در سیستم ما هست یا نه و چیه و کیه و چیکار میکنه و نقشش چیه
        //اترازیشن یعنی اینکه بهش مجوز بدیم و اینا
        //خب ما میدل ور اتنتیکشن رو اضافه کردیم
        //قبلش هم دی بی کانتکس رو به ایدنتیتی دی بی کانتکس تعغیر دادیم
        //اد میگریشن و اپدیت دیتا بیس کردیم که باعث شد ایدنتیتی کانتکس برامون جداولی توی اس کیو ال سرور بسازه که
        //بفهمیم هر کاربر چیه و کیه و نقشش چیه و چیکارا میکنه
        //بعد هم که میدل ور اتنتیکیشن داریم در کنار ایدنتیتی دی بی کانتکس میرن و اطلاعات رو میارن

        //خب حالا برای استفاده از این اتنتیکیشن یک راهبرد دستی داریم که بیایم خودمون یک کنترلر براش درست کنیم که
        //لاگ این و لاگ اوت و ساین اپ و فرگت پسورد و اینا داشته باشه و
        //مشخصن یک ویو با مشخصات بالا
        //و یا میتونیم از یک قالب دیفالت استفاده کنیم که اون قالب یک ریزور کلاس لایبرری هتش
        //ریزور کلاس لایبرری چیست؟
        //هاوی کنترلر ، ویو ، پیج ، ویو کامپوننت و چیز های دیگست
        //اجزای داخل این کلاس لایبریی اور راید میشوند
        //مشخصا کد ما چه قدیمیش چه جدیدش اورراید میکنه کد لایبرری رو

        //خب اضافه کردن اتنتیکیشن
        //ما میتونیم که خودمون این کار رو بکنیم یا از قالب اماده استفاده کنیم
        //بهش میگن اسکافلدینگ یا همون داربست من بهش میگم قالب
        //برای انجامش که خود ویژوال استدیو برامون انجامش میده بریم به پروژه و کلیک راست کنیم روش
        //بعد اد رو بزنیم و بعد نیو اسکافلدینگ ایتم بریم به تب ایدنتیتی تا کلاس های ایدنتیتی رو بیاریم و ریزور کلاس لایبرریش رو
        //کلن یه ایتم به اسم ایدنتیتی پیدا میکنیم و انتخابش کنیم و اد
        //اوکی بعد میاد و اد پکیج ناگت میکنه و بعدش ما اد ایدنتیتی میکنیم و میگیم که کدوم هارو میخوایم و
        //بعد هم کلاس دی بی کانتکس رو مشخص میکنیم و تمام
        //خب اسکافلدین اول از همه اومده و در پرگرام دات سی اس تعغیرات ایجاد کرده
        //فولدر اریاز توسط ای اس پی شناخته شده هست و تمام توابع و عملکرد های مشابه رو میزاره درون یک فولدر هم نام
        //مثلا اینجا همه فانکشنالیتی های مرتبط به ایدنتیت رو گذاشته داخل فولدر ایدنتیتی
        //داخل ایدنتیتی پیجز و بعد اکانت همه اون چیزایی هست که ما موقع اد ایدنتیتی به پروژه اد کردیم و اماده هستن که اورراید بشن
        //خب بریم اوررایت کنیم
        //رجیستر
        //توش ریزور هست و اچ تی ام ال داره که وارد میکنن ایمیل رو و پسورد رو و کانفرم پسورد
        //بعد کد بیهایند داره یاا همون پیج مدل کلاس
        //و اونجا ان پست اسینک داره یک متد داره داخل کد بیهایند که همه کار های ساخت یک کاربر رو توی دیتا بیس ما بر عهده داره
        //در لاگ این و رجیستر یک قسمت 
        //                @section Scripts   {        <partial name = "_ValidationScriptsPartial" />        }
        //که ما باید یک رندر سکشن بدیم که کد های ریزور کلاس لایبرری از سمت لای اوت خودمون قابل دسترسی باشند
        //اینجوریه که هم توی لی اوت خودمونه این اسکریپت هم در ریزور کلاس لایبرری
        //پس میریم به لی اوت خودمون و زیر رندر بادی اینو اد میکنیم
        //@RenderSection("Scripts" , required:false)
        //کلمه اسکریپتس
        //Scripts
        //اسم پارشال نیم رندر اسکریپت لاگ این و رجیستر هستش
        //توی فولدر شیرد ویو ها یک فایل دیگه هم هست به اسم لاگ این پارشال که خود اسکافلدینگ برامون ساختتش
        //چی توشه خب اگه یوزر لاگ این کرده میاد و اسم یوزر رو نشون میده اگر نکرده دکمه لاگ این و رجیستر رو نشون میده
        //برای استفادش باید بریم به لی اوت خودمون و پارشال ویوش رو در نو بار خودمون اضافه کنیمش
        //بریم داخلش
        //کامنت داره

        //اتورزیشن
        //ازش استفاده میکنیم تا دسترسی کاربر رو به بعضی چیزا باز کنیم یا ببندیم
        //برای استفاده ازش میدلور اون رو زیر اتنتیکیشن اضافه میکنیم
        //app.UseAuthorization();
        //خب حالا مثلن اگه بخوایم که نتونه به چک اوت کردن دسترسی داشته باشه چی؟
        //میام و در کنترلر اوردر کنترلر اتربیوت اترایز رو اضافه میکنیم این شکلی فقط اگه ساین این کرده باشه میتونه به 
        //کنترلر دسترسی داشته باشه
        //و اگر اتربیوت رو بالای اکشن متد بزاریم فقط به اون متد دسترسی نداره اگه که ساین این نکرده باشه
        //حالا اگر که ساین این نکرده باشه چی ؟ ریدایرکت میشه به لاگ این و بعد از این که لاگ این کرددوباره ریدایکرت میشه
        //به جایی که انتظار داشت بشه


































































    }
}
