namespace MyProject.Interfaces;

public interface IOrderService
{
    public Task<IEnumerable<MinimalOrderViewModel>> GetMiminalOrdersAsync();
    public Task<IEnumerable<OrderViewModel>> GetOrdersAsync();
}
