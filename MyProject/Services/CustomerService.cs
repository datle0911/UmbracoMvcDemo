namespace MyProject.Services;

public class CustomerService : ICustomerService
{
    private readonly HttpClient _httpClient = null!;

    public CustomerService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<IEnumerable<CustomerViewModel>> GetAllCustomersAsync()
    {
        // No need to create Client

        var response = await _httpClient.GetFromJsonAsync<IEnumerable<CustomerViewModel>>("https://deliverywebapi.azurewebsites.net/api/customers");

        if (response is not null)
        {
            return response;
        }

        return null;
    }

    public async Task<CustomerViewModel> GetCustomerByFullNameAsync(string fullName)
    {
        var response = await _httpClient.GetFromJsonAsync<CustomerViewModel>("https://deliverywebapi.azurewebsites.net/api/customers" + "/" + fullName);

        if (response is not null)
        {
            return response;
        }

        return null;
    }
}
