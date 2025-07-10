using Microsoft.EntityFrameworkCore;
using MVC_Area.Models.Northwind;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Repositories.Concretes
{
    public class CategoryRepository : ICategoryRepository
    {
        private readonly NorthwindContext _context;
        public CategoryRepository(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<int> GetCategoryCountAsync()
        {
            return await _context.Categories.CountAsync();
        }

    }
}
