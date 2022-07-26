namespace MyProject.Interfaces;

public interface IProductService
{
    public Task<IEnumerable<MinimalProductViewModel>> GetMiminalProductsAsync();
    public Task<IEnumerable<ProductViewModel>> GetProductsAsync();
}
