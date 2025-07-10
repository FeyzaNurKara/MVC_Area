namespace MVC_Area.Repositories.Abstracts
{
    public interface ISupplierRepository
    {
        Task<int> GetSupplierCountAsync();
    }
}
