namespace MVC_Area.Repositories.Abstracts
{
    public interface IOrdersDetailsRepository
    {
        Task<int> GetOrdersDetailsCountAsync();
    }
}
