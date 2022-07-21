namespace MyProject.Interfaces;

public interface ICustomerService
{
    public Task<IEnumerable<CustomerViewModel>> GetAllCustomersAsync();
    public Task<CustomerViewModel> GetCustomerByFullNameAsync(string fullName);
    public Task<Response> PostCustomerAsync(CustomerViewModel customer);
}
