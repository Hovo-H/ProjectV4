using WebApplication1.ViewModels.Products;

namespace WebApplication1.Services.Interfaces
{
    public interface IProductService
    {
        public int Add(ProductAddEditViewModel model);
        public void Delete(int Id);
        public int Update(ProductAddEditViewModel model);
        public ProductAddEditViewModel GetById(int Id);
    }
}
