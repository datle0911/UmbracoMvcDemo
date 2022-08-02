namespace MyProject.Models.Order;

public class OrderDetail
{
    public OrderDetail()
    {

    }

    public OrderDetail(Product.Product product, int quantity, double total)
    {
        Product = product;
        Quantity = quantity;
        Total = total;
    }

    public Product.Product Product { get; set; } = new Product.Product();
    public int Quantity { get; set; }
    public double Total { get; set; }
}
