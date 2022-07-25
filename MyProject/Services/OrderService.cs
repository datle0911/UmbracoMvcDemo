namespace MyProject.Services;

public class OrderService : BaseService, IOrderService
{
    private readonly HttpClient _httpClient = null!;

    public OrderService(HttpClient httpClient, IConfiguration configuration) : base(configuration)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<MinimalOrderViewModel>> GetMiminalOrdersAsync()
    {
        var url = GetUrl("orders", true);
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<MinimalOrderViewModel>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<IEnumerable<OrderViewModel>> GetOrdersAsync()
    {
        var url = GetUrl("orders", false);
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<OrderViewModel>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }
}
