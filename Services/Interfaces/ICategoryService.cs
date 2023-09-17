using WebApplication1.ViewModels.Categories;

namespace WebApplication1.Services.Interfaces
{
    public interface ICategoryService
    {
        public List<CategoryDropdownViewModel> GetListForDropdown();
    }
}
