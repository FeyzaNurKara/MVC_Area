using Microsoft.EntityFrameworkCore;
using MVC_Area.Models.Northwind;

namespace MVC_Area.Repositories.Concretes
{
    public class OrdersDetailsRepository
    {
        private readonly NorthwindContext _context;
        public OrdersDetailsRepository(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<int> GetOrdersDetailsCountAsync()
        {
            return await _context.OrderDetails.CountAsync();
        }
    }
}
