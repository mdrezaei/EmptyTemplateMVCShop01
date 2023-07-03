using System.ComponentModel;

namespace EmptyMVCShop01.Models
{
    public class Pie
    {
        public int PieId { get; set; }
        public string Name { get; set; } = string.Empty;
        public string? ShortDescription { get; set; }
        public string? LongDescription { get; set; }
        public string? AllergyInformation { get; set;}
        public double Price { get; set; }
        public string? ImageUrl { get; set; }
        public string? ImageThumbnailUrl { get; set; }
        public bool IsPieOfTheWeek { get; set; }
        public bool InStock { get; set; }
        public int CategoryId { get; set; }
        public Category Category { get; set; } = default!;
        // علامت سوال که خب یعنی نال پذیر خب اینو که میدونیم علامت تعجب یعنی اینکه غیر قابل پذیرش مقدار نال هست
        //بهش میگن ! (null-forgiving) operator
        //میگه ممکنه مقدار نال باشه ?
        //میگه حتما ی مقداری وجود داره و نال نیست !
        //A default value expression produces the default value of a type. 

    }
}
