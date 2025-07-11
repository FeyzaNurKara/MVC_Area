using Microsoft.EntityFrameworkCore;
using MVC_Area.Models.Northwind;
using MVC_Area.Repositories.Abstracts;

namespace MVC_Area.Repositories.Concretes
{
    public class OrderDetailRepository:IOrderDetailRepository
    {
        private readonly NorthwindContext _context;
        public OrderDetailRepository(NorthwindContext context)
        {
            _context = context;
        }
        public async Task<int> GetOrdersDetailsCountAsync()
        {
            return await _context.OrderDetails.CountAsync();
        }
    }
}
