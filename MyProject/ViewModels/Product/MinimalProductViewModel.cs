﻿namespace MyProject.ViewModels.Product;

public class MinimalProductViewModel
{
    public MinimalProductViewModel(string productName, string description, double productPrice, EProductStatus productStatus)
    {
        ProductName = productName;
        Description = description;
        ProductPrice = productPrice;
        ProductStatus = productStatus;
    }

    public MinimalProductViewModel()
    {

    }

    public string ProductName { get; set; }
    public string Description { get; set; }
    public double ProductPrice { get; set; }
    public EProductStatus ProductStatus { get; set; }
}
