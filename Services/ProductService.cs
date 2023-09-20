using WebApplication1.Data;
using WebApplication1.Data.Entities;
using WebApplication1.Data.Repositories.Interfaces;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Products;

namespace WebApplication1.Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public int Add(ProductAddEditViewModel model)
        {
            Product product = new Product()
            {
                Name = model.Name,
                CategoryId = model.CategoryId,
                VendorId = model.VendorId,
                Description = model.Description,
                GbSize = model.GbSize,
                Ram = model.Ram,
                ImageUrl = model.ImageUrl,
                Color = model.Color
            };
            _productRepository.Add(product);
            return product.Id;
        }

        public void Delete(int Id)
        {
            var entity = _productRepository.GetById(Id);
            _productRepository.Delete(entity);
        }

        public ProductAddEditViewModel GetById(int Id)
        {
            var entity = _productRepository.GetById(Id);
            return new ProductAddEditViewModel
            {
                Id = entity.Id,
                Name = entity.Name,
                Color = entity.Color,
                ImageUrl= entity.ImageUrl,
                GbSize= entity.GbSize,
                Ram= entity.Ram,
                CategoryId = entity.CategoryId,
                VendorId = entity.VendorId
            };
        }

        public int Update(ProductAddEditViewModel model)
        {
            var entity = _productRepository.GetById(model.Id);
            entity.Name = model.Name;
            entity.Color = model.Color;
            entity.CategoryId = model.CategoryId;
            entity.VendorId = model.VendorId;
            entity.GbSize = model.GbSize;
            entity.Ram = model.Ram;
            entity.ImageUrl = model.ImageUrl;
            return entity.Id;
        }
    }
}
