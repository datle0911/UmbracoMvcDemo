namespace MyProject.Interfaces;

public interface ICustomerService
{
    public Task<IEnumerable<Customer>> GetAllCustomersAsync();
    public Task<IEnumerable<Customer>> GetCustomerByFullNameAsync(string fullName);
    public Task<Response> PostCustomerAsync(Customer customer);
}
