using WebApplication1.Data.Entities;
using WebApplication1.Data.Repositories.Interfaces;

namespace WebApplication1.Data.Repositories
{
    public class VendorRepository : IVendorRepository
    {
        private readonly MobileShopDataContext _context;
        public VendorRepository(MobileShopDataContext context)
        {
            _context = context;
        }
        public List<Vendor> GetAll()
        {
            return _context.Vendors.ToList();
        }
    }
}
