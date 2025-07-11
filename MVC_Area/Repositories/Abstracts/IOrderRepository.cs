namespace MVC_Area.Repositories.Abstracts
{
    public interface IOrderRepository
    {
        Task<int> GetOrderCountAsync();
    }
}
