using System;  
using System.Collections.Generic;
public class Program  
{  
    public static void Main(string[] args)  
    {  
        // Create addresses  
        Address address1 = new Address("123 Main St", "Anytown", "CA", "USA");  
        Address address2 = new Address("456 Elm St", "Othertown", "ON", "Canada");  

        // Create customers  
        Customer customer1 = new Customer("John Doe", address1);  
        Customer customer2 = new Customer("Jane Smith", address2);  

        // Create orders  
        Order order1 = new Order(customer1);  
        order1.AddProduct(new Product("Widget", 101, 3.00m, 5));  
        order1.AddProduct(new Product("Gadget", 102, 7.50m, 2));  

        Order order2 = new Order(customer2);  
        order2.AddProduct(new Product("Thingamajig", 201, 10.00m, 1));  
        order2.AddProduct(new Product("Doodad", 202, 2.50m, 4));  

        // Display order details  
        DisplayOrderDetails(order1);  
        DisplayOrderDetails(order2);  
    }  

    private static void DisplayOrderDetails(Order order)  
    {  
        Console.WriteLine(order.GetPackingLabel());  
        Console.WriteLine(order.GetShippingLabel());  
        Console.WriteLine($"Total Cost: ${order.CalculateTotalCost():0.00}");  
        Console.WriteLine(); // Blank line for readability  
    }  
}  