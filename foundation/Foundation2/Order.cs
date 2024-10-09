using System;  
using System.Collections.Generic;
public class Order  
{  
    private List<Product> _products;  
    private Customer _customer;  
    private const decimal USA_Shipping_Cost = 5.00m;  
    private const decimal International_Shipping_Cost = 35.00m;  

    public Order(Customer customer)  
    {  
        _customer = customer;  
        _products = new List<Product>();  
    }  

    public void AddProduct(Product product)  
    {  
        _products.Add(product);  
    }  

    public decimal CalculateTotalCost()  
    {  
        decimal total = 0;  
        foreach (var product in _products)  
        {  
            total += product.GetTotalCost();  
        }  
        total += _customer.LivesInUSA() ? USA_Shipping_Cost : International_Shipping_Cost;  
        return total;  
    }  

    public string GetPackingLabel()  
    {  
        string label = "Packing Label:\n";  
        foreach (var product in _products)  
        {  
            label += $"{product.GetName()} (ID: {product.GetProductId()})\n";  
        }  
        return label;  
    }  

    public string GetShippingLabel()  
    {  
        return $"Shipping Label:\n{_customer.GetName()}\n{_customer.GetAddress().GetFullAddress()}";  
    }  
}  