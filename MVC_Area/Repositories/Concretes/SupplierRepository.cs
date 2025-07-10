using Microsoft.EntityFrameworkCore;
using MVC_Area.Models.Northwind;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Repositories.Concretes
{
    public class SupplierRepository: ISupplierRepository
    {
        private readonly NorthwindContext _context;
        public SupplierRepository(NorthwindContext context)
        {
            _context = context;
        }

        public async Task<int> GetSupplierCountAsync()
        {
            return await _context.Suppliers.CountAsync();
        }

       
    }

}
