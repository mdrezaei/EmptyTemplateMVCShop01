namespace EmptyMVCShop01.Models
{
    public class CategoryRepository : ICategoryRepository
    {
        //public IEnumerable<Category> AllCategories => throw new NotImplementedException();
        //public IEnumerable<Category> AllCategories => 
        //    new List<Category>() 
        //    {
        //        new Category(){CategoryId=1, CategoryName="Fruit pies", Description="All-fruity pies"},
        //        new Category(){CategoryId=2, CategoryName="Cheese cakes", Description="Cheesy all the way"},
        //        new Category(){CategoryId=3, CategoryName="Seasonal pies", Description="Get in the mood for a seasonal pie"}
        //    };


        private readonly EmptyMVCShop01DbContext _dbContext;

        public CategoryRepository(EmptyMVCShop01DbContext dbContext)
        {
            _dbContext = dbContext;
        }

        public IEnumerable<Category> AllCategories
        {
            get
            {
                return _dbContext.Categories.OrderBy(c=>c.CategoryName).ToList();
            }
        }


    }
}
