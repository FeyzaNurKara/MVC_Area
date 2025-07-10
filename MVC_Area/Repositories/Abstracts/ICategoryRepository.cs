namespace MVC_Area.Repositories.Abstracts
{
    public interface ICategoryRepository
    {
        Task<int> GetCategoryCountAsync();
    }
}
