﻿using WebApplication1.ViewModels.Categories;
using WebApplication1.ViewModels.Vendors;

namespace WebApplication1.Services.Interfaces
{
    public interface IVendorService
    {
        public List<VendorDropdownViewModel> GetListForDropdown();
        public VendorDropdownViewModel GetById(int id);
        public int Add(VendorDropdownViewModel model);
        public void Delete(int Id);
    }
}
