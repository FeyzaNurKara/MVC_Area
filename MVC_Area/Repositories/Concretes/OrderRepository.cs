using Microsoft.EntityFrameworkCore;
using MVC_Area.Models.Northwind;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Repositories.Concretes
{
    public class OrderRepository: IOrderRepository
    {
        private readonly NorthwindContext _context;
        public OrderRepository(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<int> GetOrderCountAsync()
        {
            return await _context.Orders .CountAsync();
        }
    }
}
