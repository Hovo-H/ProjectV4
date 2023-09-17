using WebApplication1.Data.Entities;
using WebApplication1.Data.Repositories.Interfaces;
using WebApplication1.Data;

namespace WebApplication1.Data.Repositories
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly MobileShopDataContext _context;
        public CategoryRepository(MobileShopDataContext context)
        {
            _context = context;
        }
        public List<Category> GetAll()
        {
            return _context.Categories.ToList();
        }
    }
}
