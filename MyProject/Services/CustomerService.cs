namespace MyProject.Services;

public class CustomerService : BaseService, ICustomerService
{
    private readonly HttpClient _httpClient = null!;

    public CustomerService(HttpClient httpClient, IConfiguration configuration) : base(configuration)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<CustomerViewModel>> GetAllCustomersAsync()
    {
        // No need to create Client
        var url = GetUrl("customers");
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<CustomerViewModel>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<IEnumerable<CustomerViewModel>> GetCustomerByFullNameAsync(string fullName)
    {
        var url = GetUrl("customers");
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<CustomerViewModel>>(url + "/" + fullName);

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<Response> PostCustomerAsync(CustomerViewModel customer)
    {
        var url = GetUrl("customers");
        var response = await _httpClient.PostAsJsonAsync(url, customer);
        
        var result = new Response(response.Content, (Int32)response.StatusCode);
        return result;
    }
}
