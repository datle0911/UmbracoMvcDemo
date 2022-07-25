﻿namespace MyProject.ViewModels.Product;

public class ProductViewModel
{
    public ProductViewModel()
    {

    }
    public ProductViewModel(string productName, string description, byte[] productImage, double productPrice, EProductStatus productStatus)
    {
        ProductName = productName;
        Description = description;
        ProductImage = productImage;
        ProductPrice = productPrice;
        ProductStatus = productStatus;
    }

    public string ProductName { get; set; }
    public string Description { get; set; }
    public byte[] ProductImage { get; set; }
    public double ProductPrice { get; set; }
    public EProductStatus ProductStatus { get; set; }
}
