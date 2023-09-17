using WebApplication1.Data.Entities;

namespace WebApplication1.Data.Repositories.Interfaces
{
    public interface IVendorRepository
    {
        List<Vendor> GetAll();
    }
}
