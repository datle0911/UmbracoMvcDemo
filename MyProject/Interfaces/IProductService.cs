namespace MyProject.Interfaces;

public interface IProductService
{
    public Task<IEnumerable<MinimalProduct>> GetMiminalProductsAsync();
    public Task<IEnumerable<Product>> GetProductsAsync();
    public Task<Product> GetProductDetailsById(int id);
}
