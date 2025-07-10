namespace MVC_Area.Repositories.Abstracts
{
    public interface IProductRepository
    {
        Task<int> GetProductCountAsync();
    }
}
