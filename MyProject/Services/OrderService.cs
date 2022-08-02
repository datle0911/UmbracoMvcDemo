namespace MyProject.Services;

public class OrderService : BaseService, IOrderService
{
    private readonly HttpClient _httpClient = null!;

    public OrderService(HttpClient httpClient, IConfiguration configuration) : base(configuration)
    {
        _httpClient = httpClient;
    }
    
    public async Task<IEnumerable<MinimalOrder>> GetMiminalOrdersAsync()
    {
        var url = GetUrl("orders", true);
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<MinimalOrder>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<IEnumerable<Order>> GetOrdersAsync()
    {
        var url = GetUrl("orders", false);
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<Order>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }
}
