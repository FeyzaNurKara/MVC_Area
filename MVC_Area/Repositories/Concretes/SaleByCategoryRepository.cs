using Microsoft.EntityFrameworkCore;
using MVC_Area.Models.Northwind;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Repositories.Concretes
{
    public class SaleByCategoryRepository:ISaleByCategoryRepository
    {
        private readonly NorthwindContext _context;
        public SaleByCategoryRepository(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<int> GetSaleByCategoryCountAsync()
        {
            return await _context.SalesByCategories.CountAsync();
        }

        
    }
}
