namespace Blazor.Web.Services
{
    public interface IProductService
    {
        Task<List<string>> GetProductsAsync();
    }
}
