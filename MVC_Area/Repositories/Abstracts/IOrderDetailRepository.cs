namespace MVC_Area.Repositories.Abstracts
{
    public interface IOrderDetailRepository
    {
        Task<int> GetOrdersDetailsCountAsync();
    }
}
