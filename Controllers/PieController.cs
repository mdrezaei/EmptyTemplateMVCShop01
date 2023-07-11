using Microsoft.AspNetCore.Mvc;
using EmptyMVCShop01.Models;
using EmptyMVCShop01.ViewModels;

namespace EmptyMVCShop01.Controllers
{
    public class PieController : Controller
        //کنترلر ها کلاس هایی اند که پسوند کنترلر دارند و از کلاس کنترلر (کلاس بیس) ارث بری میکنن
    {
        //فیلد پرایویت رید انلی درست کنیم
        private readonly IPieRepository _pieRepository;
        private readonly ICategoryRepository _categoryRepository;
        
        //حالا کانستراکتور بسازیم که مقدار جفت فیلد بالا رو بدیم
        public PieController(IPieRepository pieRepository, ICategoryRepository categoryRepository)
        {
            _pieRepository = pieRepository;
            _categoryRepository = categoryRepository;

            //و چون ما قبلن این سرویس هارو اد و رجیستری کردیم به دی ای کانتینر در پرگرام دات سی اس الان که
            //اینترفیس رو صدا میزنیم سرویسشون یا
            //همون کلاسی که ازشون ایمپلیمنت شده ، اینستنسش ساخته میشه و فراخوانی میشه و اینجکت میشه به اینجا
            //پس هروقت کانستراکتور ران بشه اینستنس ها فراخوانی میشوند
        }

        //public ActionResult PieList() 
        //{
        //    //return View(_pieRepository.AllPies);
        //    ////اینجا ما نه تنها یک ویو رو میفرستیم بلکه داریم همراه ویو دیتا هم میفرستیم . داریم یک ای اینامریبل میفرستیم
        //    ////به این ویو میگن ویو دیتا مادل 
        //    ////با ویو مدل متفاوته . ویو مدل مدلی هست که بختص ویویی که میخوایم نشون بدیم ساخته شده
        //    ////ویو مدل ها انتیتی نیستن که برن توی دیتا بیس . یه چیزی برای بین ویو ها و مدل ها هستند
        //    ////این پای ریپوزیتوری . ال پایز از چه جنسی هست؟

        //    ViewBag.Title = "Our Pies";
        //    //این ویو بگ مال تایتل لی اوت هستش

        //    PieListViewModel pieListViewModel = new PieListViewModel(_pieRepository.AllPies, "Our Delisus Pies");
        //    return View(pieListViewModel);
        //    //خب چرا از مدل میو استفاده کردیم 
        //    //چون اگه بخوایم چندین متغیر و دیتا وارد ویو کنیم دو حالت داره یا در متغیر های مختلف درون کنترلر اینیشیلایز کنیم و 
        //    //مقدار دهی اولیه کنیم توسط ویو بگ های متعدد وابجکتی که از روی اینترفیس و ریپوزیتوری مدل ساختیم و بعد
        //    //بریم توی ویو هی ویو بگ هارو صدا کنیم و چون فقط هم یک مادل داریم
        //    //نمیتونیم دیتا های متفاوت وارد کنیم به ویو
        //    //و راه دوم هم اینه که دیتا رو استاتیک درون تکست های اچ تی ام ال به کار ببریم که خب اصن راهی برای 
        //    //دیتا های داینامیک نمیزاره و پراپرتی ها و مدل های مختلف نمیتونن وارد شن
        //    //پس اگه بخوایم دیتا های متفوتی رو پاس بدیم به ویو سخت و حتی نشدنی میشه
        //    //پس در عوض میایم یک ویو مدل میسازیم و برای همه دیتا هایی که میخوایم ببریم سمت ویو پراپرتی درست میکنیم
        //    //با استفاده کانستراکتورش مقدار میدیم این پراپرتی هارو و در کنترلر کانستراکتورش رو پر میکنیم و بعد 
        //    //ان ابجکتی را که از این ویو مدل ساختیم را پاس میدیم به ویو 
        //    //پس مشکل ادم استفاده از ویو مدل اینه که ما فقط میتونیم یک دیتای داینامیک به
        //    //ویو بفرستیم چون یک مدل در ویو داریم و یک ابجکت مدل که مقدار دهی میشود در کنترلر داریم
        //    //و باقی دیتا های ارسالی استاتیک اند
        //    //ولی چی میشه اگه بخوایم از چندین دیتای داینامیک استفاده کنیم خب میایم یک
        //    //ویو مدل میسازیم با پراپ های مختلف برای مدل های مختلف بعد میایم توی کنترلر اون ویو مدل رو توسط کانستراکتورش
        //    //از دیتای مدل های مختلف پر میکنیم و بعد پاسش میدیم به یگانه مدل ویو

        //}

        //این پای لیست بالایی کتگوری نمیتونست قبول کنه

        //این ویو ریزالت برمیگردونه با اکشن ریزالت چه تفاوتی داره
        //ویو ریزالت خب ویو بر میگردونه و ویو برای ویو ریزالت هستش
        //کلاس ویو ریزالت از کلاس اکشن ریزالت ارث بری کرده
        //وقتی ویو بر میگرده اگه متدی باشه که باید ویو ریزالت بر گردونه که هیچی درسته ولی اگه باید اکشن ریزالت برگردونه
        //با پلیمرفیسم میتونه همون ویو رو بر گردونه . ما یه عالم ریزالت های مختلف داریم که فقط بعضیاشون ویو بر میگردونن 
        //باقیشون امکان داره پارشال ویو یا اچ تی تی پی ریکوئست یا یو ار ال یا جیسان بفرستن. جای اینکه همه اینارو ما
        //توی متدمون ذکر کنیم میایم و از اکشن ریزالت یا ای اکشن ریزالت استفاده میکنیم
        public ViewResult PieList(string category)
        {
            IEnumerable<Pie> pies;
            string? currentCategory;

            if (string.IsNullOrEmpty(category))
            {
                pies = _pieRepository.AllPies.OrderBy(p => p.PieId);
                currentCategory = "All pies";
            }
            else
            {
                pies = _pieRepository.AllPies.Where(p => p.Category.CategoryName == category)
                    .OrderBy(p => p.PieId);
                currentCategory = _categoryRepository.AllCategories.FirstOrDefault(c => c.CategoryName == category)?.CategoryName;
            }

            return View(new PieListViewModel(pies, currentCategory));
        }

        public ActionResult PieDetail(int id)
        {
            //The IActionResult return type is appropriate when multiple ActionResult return types are possible in an action.
            //The ActionResult types represent various HTTP status codes. Any non-abstract class deriving from
            //ActionResult qualifies as a valid return type

            ViewBag.Title = "Pie Info";

            var pie =_pieRepository.GetPieById(id);
            if (pie == null)
            {
                return NotFound();
            }
            return View(pie);
        }
    }
}
