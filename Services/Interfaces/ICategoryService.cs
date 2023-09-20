using WebApplication1.ViewModels.Categories;

namespace WebApplication1.Services.Interfaces
{
    public interface ICategoryService
    {
        public List<CategoryDropdownViewModel> GetListForDropdown();
        public CategoryDropdownViewModel GetById(int id);
        public int Add(CategoryDropdownViewModel model);
        public void Delete(int Id);
    }
}
