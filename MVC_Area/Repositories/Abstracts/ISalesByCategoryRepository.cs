namespace MVC_Area.Repositories.Abstracts
{
    public interface ISalesByCategoryRepository
    {
        Task<int> GetSalesByCategoryCountAsync();
    }
}
