using WebApplication1.ViewModels.Vendors;

namespace WebApplication1.Services.Interfaces
{
    public interface IVendorService
    {
        public List<VendorDropdownViewModel> GetListForDropdown();
    }
}
