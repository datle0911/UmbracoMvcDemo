namespace MyProject.Interfaces;

public interface ICustomerService
{
    public Task<IEnumerable<CustomerViewModel>> GetAllCustomersAsync();
    public Task<IEnumerable<CustomerViewModel>> GetCustomerByFullNameAsync(string fullName);
    public Task<Response> PostCustomerAsync(CustomerViewModel customer);
}
