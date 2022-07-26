namespace MyProject.Services;

public class ProductService : BaseService, IProductService
{
    private readonly HttpClient _httpClient = null!;
    public ProductService(HttpClient httpClient, IConfiguration configuration) : base(configuration)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<MinimalProductViewModel>> GetMiminalProductsAsync()
    {
        var url = GetUrl("products", true);
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<MinimalProductViewModel>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<IEnumerable<ProductViewModel>> GetProductsAsync()
    {
        var url = GetUrl("products", false);
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<ProductViewModel>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }
}
