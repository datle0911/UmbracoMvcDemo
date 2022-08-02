namespace MyProject.Services;

public class CustomerService : BaseService, ICustomerService
{
    private readonly HttpClient _httpClient = null!;

    public CustomerService(HttpClient httpClient, IConfiguration configuration) : base(configuration)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<Customer>> GetAllCustomersAsync()
    {
        // No need to create Client
        var url = GetUrl("customers");
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<Customer>>(url);

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<IEnumerable<Customer>> GetCustomerByFullNameAsync(string fullName)
    {
        var url = GetUrl("customers");
        var response = await _httpClient.GetFromJsonAsync<IEnumerable<Customer>>(url + "/" + fullName);

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<Response> PostCustomerAsync(Customer customer)
    {
        var url = GetUrl("customers");
        var response = await _httpClient.PostAsJsonAsync(url, customer);
        
        var result = new Response(response.StatusCode.ToString(), (Int32)response.StatusCode);
        return result;
    }
}
