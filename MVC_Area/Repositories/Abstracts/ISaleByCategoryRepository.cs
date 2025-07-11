namespace MVC_Area.Repositories.Abstracts
{
    public interface ISaleByCategoryRepository
    {
        Task<int> GetSaleByCategoryCountAsync();
    }
}
