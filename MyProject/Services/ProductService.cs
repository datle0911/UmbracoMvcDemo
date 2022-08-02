namespace MyProject.Services;

public class ProductService : BaseService, IProductService
{
    private readonly HttpClient _httpClient = null!;
    public ProductService(HttpClient httpClient, IConfiguration configuration) : base(configuration)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<MinimalProduct>> GetMiminalProductsAsync()
    {
        var url = GetUrl("products", true);
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<MinimalProduct>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<Product> GetProductDetailsById(int id)
    {
        var url = GetUrl("products", id.ToString());
        var response = await _httpClient.GetFromJsonAsync<Product>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<IEnumerable<Product>> GetProductsAsync()
    {
        var url = GetUrl("products", false);
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<Product>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }
}
