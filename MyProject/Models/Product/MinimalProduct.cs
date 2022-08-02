namespace MyProject.Models.Product;

public class MinimalProduct
{
    public MinimalProduct(int productId, string productName, string description, double productPrice, EProductStatus productStatus)
    {
        ProductId = productId;
        ProductName = productName;
        Description = description;
        ProductPrice = productPrice;
        ProductStatus = productStatus;
    }

    public MinimalProduct()
    {

    }

    public int ProductId { get; set; }
    public string ProductName { get; set; }
    public string Description { get; set; }
    public double ProductPrice { get; set; }
    public EProductStatus ProductStatus { get; set; }
}
