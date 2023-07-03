using Microsoft.AspNetCore.Razor.TagHelpers;

namespace EmptyMVCShop01.TagHelpers
{
    public class EmailTagHelper:TagHelper
    {
        public string? Address { get; set; }
        public string? Content { get; set; }

        //دوتا متد داره یکیش پروسس اسینک هست یکی دیگش هم پروسس همزمان که از همون پروسس یا همون پروسس هم زمان استفاده میکنیم
        //این متد باید اور راید بشه
        public override void Process(TagHelperContext context, TagHelperOutput output)
        {
            //خب اینجا ما در کانتکس به همه اطلاعات کانتکس که اجرا میشود دسترسی داریم ولی کار اصلیمون با اوت پوت هست
            //چون یه تگ میل تو لینک میخوایم درست کنیم پس این تگ هلپر ما در واقع یک تگ ای هستش
            output.TagName = "a";
            //حالا اتربیوت هارو اضافه میکنیم
            output.Attributes.SetAttribute("href", "mailto:" + Address);
            //به اینشکل هست که استرینگ اولی اسم اتربیوت هستش که کارش هم مشخصه
            //ابجکت بعدی یا حالا اینجا یه استرینگ هست که اضافه شده به
            //یک استرینگ دیگه ، مقدار و ولیو یی که این اتربیوت میتونه داشته باشه هستش
            
            output.Content.SetContent(Content);
            //این هم کانتنت و محتوایی که بین تگ باز و بسته قرار میگیره رو ست میکنه
        }

        //خب حالا بریم تگ هلپر هامون رو اد کنیم
    }
}
