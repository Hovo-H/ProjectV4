using WebApplication1.Data.Entities;
using WebApplication1.Data.Repositories.Interfaces;
using WebApplication1.Services.Interfaces;
using WebApplication1.ViewModels.Categories;
using WebApplication1.ViewModels.Vendors;

namespace WebApplication1.Services
{
    public class VendorService : IVendorService
    {
        private readonly IVendorRepository _vendorRepository;
        public VendorService(IVendorRepository vendorRepository)
        {
            _vendorRepository = vendorRepository;
        }
        List<VendorDropdownViewModel> IVendorService.GetListForDropdown()
        {
            var data = _vendorRepository.GetAll();
            return data.Select(v => new VendorDropdownViewModel
            {
                Id = v.Id,
                Name = v.Name,
            }).ToList();
        }
    }
}
