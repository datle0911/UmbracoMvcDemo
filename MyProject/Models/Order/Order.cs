namespace MyProject.Models.Order;

public class Order
{
    public Order(string orderId, Customer customer, List<OrderDetail> details, DateTime orderTimestamp, string orderAddress, string orderQrCode, string orderRobot, double totalPrice, EOrderStatus orderStatus, EOrderTracking orderTracking)
    {
        OrderId = orderId;
        Customer = customer;
        Details = details;
        OrderTimestamp = orderTimestamp;
        OrderAddress = orderAddress;
        OrderQrCode = orderQrCode;
        OrderRobot = orderRobot;
        TotalPrice = totalPrice;
        OrderStatus = orderStatus;
        OrderTracking = orderTracking;
    }
    public Order()
    {

    }

    public string OrderId { get; set; }
    public Customer Customer { get; set; } = new Customer();
    public List<OrderDetail> Details { get; set; } = new List<OrderDetail>();
    public DateTime OrderTimestamp { get; set; }
    public string OrderAddress { get; set; }
    public string OrderQrCode { get; set; }
    public string OrderRobot { get; set; }
    public double TotalPrice { get; set; }
    public EOrderStatus OrderStatus { get; set; }
    public EOrderTracking OrderTracking { get; set; }
}
