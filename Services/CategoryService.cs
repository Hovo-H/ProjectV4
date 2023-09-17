using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Categories;
using WebApplication1.Data.Repositories.Interfaces;

namespace WebApplication1.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly ICategoryRepository _categoryRepository;
        public CategoryService(ICategoryRepository categoryRepository)
        {
            _categoryRepository = categoryRepository;
        }
        public List<CategoryDropdownViewModel> GetListForDropdown()
        {
            var data = _categoryRepository.GetAll();
            return data.Select(c => new CategoryDropdownViewModel
            {
                Id = c.Id,
                Name = c.Name,
            }).ToList();
        }
    }
}
