using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using MVC_Area.Models.Northwind;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Repositories.Concretes
{
    public class ProductRepository : IProductRepository
    {
        private readonly NorthwindContext _context;
        public ProductRepository(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<int> GetProductCountAsync()
        {
            return await _context.Products.CountAsync();
        }

  
    }
}
