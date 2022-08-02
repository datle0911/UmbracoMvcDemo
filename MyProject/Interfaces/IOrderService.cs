namespace MyProject.Interfaces;

public interface IOrderService
{
    public Task<IEnumerable<MinimalOrder>> GetMiminalOrdersAsync();
    public Task<IEnumerable<Order>> GetOrdersAsync();
}
